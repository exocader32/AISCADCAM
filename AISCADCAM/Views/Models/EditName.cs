using System;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AISCADCAM
{
    /// <summary>
    /// форма изменения/создания имени (+ цены в материалах) и кол-ва на складе 
    /// </summary>
    public partial class EditName : Form
    {
        public static string Value = null;
        public static string Type = null;
        public static float Price = -1f;
        public static int Count = -1;

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        private string _type = null, _value = null;
        private float _price;
        private int _count;

        public EditName(string type, string value = null, float price = -1f,int count=-1)
        {
            Value = Type = null;
            Price = -1; Count = -1;
            _count = count;
            InitializeComponent();
            if (price < 0)
                label1.Width = textBox1.Width = 464;
            Text = $"{((_value=value)==""?"СОЗДАНИЕ":"ИЗМЕНЕНИЕ")} {(_type=type).ToUpper()}";
            textBox1.Text = value;
            textBox2.Text = (_price=price).ToString("C");
            l3.Visible = t3.Visible = count>=0;
            t3.Text = count.ToString();
            t3.TextChanged+= T3OnTextChanged;
        }

        private void EditName_Load(object sender, EventArgs e)
        {
            // подпись на события изменения данных пользователем
            textBox1.TextChanged += (o, args) => _value = textBox1.Text.Trim();
            textBox2.TextChanged += (o, args) => _price = GetValue(textBox2);
        }

        // преобразовать текст в float
        private float GetValue(TextBox tb)
        {
            if (float.TryParse(tb.Text.Split(' ').First(), out float value))
                return value;
            return 0f;
        }

        // валидация изменения кол-ва
        private void T3OnTextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb == null) return;
            var valueString = tb.Text.Trim();
            if (int.TryParse(valueString, out int value))
            {
                tb.BackColor = SystemColors.Window;
                tb.Text = value.ToString();
                _count = value;
            }
            else tb.BackColor = Color.DarkSalmon;
        }

        // валидация изменения цены
        private void price_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb == null) return;
            var valueString = tb.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, null).Trim();
            if (float.TryParse(valueString, out float value))
            {
                tb.BackColor = SystemColors.Window;
                tb.Text = value.ToString("C");
            }
            else tb.BackColor = Color.DarkSalmon;
        }

        // ОК
        private void button1_Click(object sender, EventArgs e)
        {
            // созранить изменения
            Type = _type;
            Value = _value;
            Price = _price;
            Count = _count;
            // выход
            Close();
        }

    }
}
