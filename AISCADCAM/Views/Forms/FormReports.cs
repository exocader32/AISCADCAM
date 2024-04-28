using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Models;
using MaterialSkin.Controls;

namespace AISCADCAM
{
    /// <summary> Форма отчётов </summary>
    public partial class FormReports : MaterialForm
    {
        public FormReports()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = (int)Instance.CurrentUser.Type;
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
        }

        // отчет бухгалтера - по покупкам
        private void BuhPay_Click(object sender, EventArgs e)
        {
            string file = $"Дата создания;\tСтоимость;\tСкидка;\tОплачено;\tЗаметки;\t\r\n";
            foreach (Order o in Instance.DB.Orders.ToList())
                if(o.Create.Date >= monthCalendar4.SelectionStart.Date &&
                            o.Create.Date <= monthCalendar3.SelectionStart.Date)
                file += $"{o.Create.Date};\t{o.Price};\t{o.Discount};\t{(o.IsPayment?"да":"нет")};\t{o.Commentary};\t\r\n";
            Directory.CreateDirectory("Reports");
            File.WriteAllText($"Reports\\{DateTime.Now:MMddyyyy}_buh.csv",file, Encoding.UTF8);
            Process.Start($"Reports\\{DateTime.Now:MMddyyyy}_buh.csv");
        }

        // отчет бухгалтера - по заказам
        private void BuhOrders_Click(object sender, EventArgs e)
        {
            string file = $"Дата создания;\tСтоимость;\tСкидка;\tОплачено;\tЗаметки;\t\r\n";
            foreach (Order o in Instance.DB.Orders.ToList())
                if(o.Create.Date >= monthCalendar4.SelectionStart.Date &&
                            o.Create.Date <= monthCalendar3.SelectionStart.Date)
                file += $"{o.Create.Date};\t{o.Price};\t{o.Discount};\t{(o.IsPayment?"да":"нет")};\t{o.Commentary};\t\r\n";
            Directory.CreateDirectory("Reports");
            File.WriteAllText($"Reports\\{DateTime.Now:MMddyyyy}_buh_order.csv",file, Encoding.UTF8);
            Process.Start($"Reports\\{DateTime.Now:MMddyyyy}_buh_order.csv");
        }

        // отчёт специалиста
        private void button1_Click(object sender, EventArgs e)
        {
            string file = $"Дата создания;\tБланк;\tЗубы;\tЗаметки;\t\r\n";
            foreach (Order o in Instance.DB.Orders.ToList())
                if(o.Create.Date >= monthCalendar1.SelectionStart.Date &&
                            o.Create.Date <= monthCalendar2.SelectionStart.Date)
                file += $"{o.Create.Date};\t{o.Blank};\t{o.Tooths};\t{o.Commentary};\t\r\n";
            Directory.CreateDirectory("Reports");
            File.WriteAllText($"Reports\\{DateTime.Now:MMddyyyy}_spec.csv",file, Encoding.UTF8);
            Process.Start($"Reports\\{DateTime.Now:MMddyyyy}_spec.csv");
        }
    }
}
