using System;
using System.Linq;
using AISCADCAM.Core;
using AISCADCAM.Models;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using Color = AISCADCAM.Models.Color;

namespace AISCADCAM.Views.Models
{
    /// <summary>
    /// форма правки заказ-наряда
    /// </summary>
    public partial class EditOrder : Form
    {
        public static Order Result = null;

        private Order _order = null;

        public EditOrder(Order order)
        {
            Result = null;
            _order = order;
            InitializeComponent();
            Text = $"{(_order.Id == 0 ? "СОЗДАНИЕ" : "ИЗМЕНЕНИЕ")} ЗАЯВКИ";
            button4.Text = (_order.Id == 0 ? "СОЗДАТЬ" : "ИЗМЕНИТЬ");
        }

        // открытие формы
        private void EditOrder_Load(object sender, EventArgs e)
        {
            // заполнение данных
            if(_order.Create<dat.MinDate) _order.Create = DateTime.Now;
            dat.Value = _order.Create;
            patients.Items.AddRange(Instance.DB.Patients.ToArray());
            patients.SelectedItem = _order.Patient;
            stabilizator.Checked = _order.Stabilizator;
            clients.Items.Add("");
            clients.Items.AddRange(Instance.DB.Clients.ToArray());
            clients.SelectedItem = _order.Client;
            tootch.Text = _order.Tooths;
            price.Text = _order.Price.ToString("C");
            discount.Text = _order.Discount.ToString("C");
            payment.Text = _order.Payment.ToString("C");
            free.Checked = _order.FreeRevision;
            ispayment.Checked = _order.IsPayment;
            blank.Text = _order.Blank?.ToString();
            stabilizator.Visible = _order?.Blank?.Material?.Name == "Zr02";
            switch (Instance.CurrentUser.Type)
            {
                case EUser.Специалист:
                    stabilizator.Enabled = ispayment.Enabled = price.Enabled = free.Enabled = discount.Enabled = payment.Enabled = false;
                    break;
                case EUser.Бухгалтер:
                    clients.Enabled = bBlank.Enabled = patients.Enabled = dat.Enabled = tootch.Enabled = selectTootch.Enabled = false;
                    break;
            }
            // обработать измение данных
            dat.ValueChanged += (o, args) => _order.Create = dat.Value;
            patients.SelectedIndexChanged += (o, args) => _order.Patient = (Patient)patients.SelectedItem;
            stabilizator.CheckedChanged += (o, args) => _order.Stabilizator = stabilizator.Checked;
            clients.SelectedIndexChanged += (o, args) =>
            {
                if(clients.SelectedIndex>0)
                    _order.Client = (Client)clients.SelectedItem;
            };
            price.TextChanged += (o, args) => _order.Price = GetValue(price);
            discount.TextChanged += (o, args) => _order.Discount = GetValue(discount);
            payment.TextChanged += (o, args) => _order.Payment = GetValue(payment);
            free.CheckedChanged += (o, args) => _order.FreeRevision = free.Checked;
            ispayment.CheckedChanged += (o, args) => _order.IsPayment = ispayment.Checked;
        }

        // взять из TextBox цену 
        private float GetValue(TextBox tb)
        {
            if (float.TryParse(tb.Text.Split(' ').First(), out float value))
                return value;
            return 0f;
        }

        // ok
        private void Ok(object sender, EventArgs e)
        {
            // если заказ новый - сохранить в бд
            if (_order.Id == 0) _order = Instance.DB.Orders.Add(_order);
            // иначе обновить заказ
            else Instance.DB.Orders.AddOrUpdate(_order);
            // сохранить изменения в бд
            Instance.DB.SaveChanges();
            Result = _order;
            // закрыть форму
            Close();
        }

        // валидация цены
        private void price_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if(tb==null) return;
            var valueString = tb.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol,null).Trim();
            if (float.TryParse(valueString, out float value))
            {
                tb.BackColor = SystemColors.Window;
                tb.Text = value.ToString("C");
            }
            else tb.BackColor = System.Drawing.Color.DarkSalmon;
        }

        // правка номеров зубов
        private void selectTootch_Click(object sender, EventArgs e)
        {
            // вызов формы выбора номеров зубов
            new SelectTooth(_order.Tooths) { Owner = this }.ShowDialog(this);
            if (SelectTooth.Result != null)
                tootch.Text = _order.Tooths = SelectTooth.Result;
        }

        // смена чекбоксов по клику на описании
        private void title11_Click(object sender, EventArgs e) => free.Checked = !free.Checked;
        private void title7_Click(object sender, EventArgs e) => stabilizator.Checked = !stabilizator.Checked;

        // правка бланка заказ-наряда
        private void bBlank_Click(object sender, EventArgs e)
        {
            // вызвать формы правки бланка
            new EditBlank(_order.Blank) { Owner = this }.ShowDialog(this);
            // созранить результат
            _order.Blank = EditBlank.Result;
            // обновить новые данные
            blank.Text = _order.Blank?.ToString();
            stabilizator.Visible = _order?.Blank?.Material?.Name == "Zr02";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditName("ПАЦИЕНТА",""){Owner=this, Title = "ФИО пациента"}.ShowDialog(this);
            if(string.IsNullOrEmpty(EditName.Value)) return;
            var p = new Patient(EditName.Value, "");
            p=Instance.DB.Patients.Add(p);
            Instance.DB.SaveChanges();
            patients.Items.Add(p);
            patients.SelectedItem = p;
        }

        private void bClient_Click(object sender, EventArgs e)
        {
            var c = clients.SelectedIndex>0?(Client)clients.SelectedItem:null;
            if (c == null) c = new Client();
            new EditClient(c) { Owner = this }.ShowDialog(this);
            if(EditClient.Result==null) return;
            if (EditClient.Result.Id == 0)
            {
                Instance.DB.Clients.Add(EditClient.Result);
                if(clients.SelectedIndex>0)
                    clients.Items[clients.SelectedIndex] = EditClient.Result;
                else
                {
                    clients.Items.Add(EditClient.Result);
                    clients.SelectedIndex = clients.Items.Count - 1;
                }
            }
            else
            {
                Instance.DB.Clients.AddOrUpdate(EditClient.Result);
                clients.Items.Add(EditClient.Result);
                clients.SelectedIndex = clients.Items.Count - 1;
            }
            Instance.DB.SaveChanges();
        }
    }
}
