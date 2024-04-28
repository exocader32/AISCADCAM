using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AISCADCAM
{
    /// <summary> выбор № зубов </summary>
    public partial class SelectTooth : Form
    {
        public static string Result = null;
        private string _tootch = null;
        public SelectTooth(string tootch)
        {
            Result = null;
            InitializeComponent();
            label2.Text = $"{_tootch = tootch}";
        }

        private void SelectTooth_Load(object sender, EventArgs e)
        {
            // заполнить данные
            if (!string.IsNullOrEmpty(_tootch))
            {
                var s = _tootch?.Split(',').ToList();
                foreach (Control c in Controls)
                    if (c is Button btn && btn.Text != "OK")
                    {
                        btn.BackColor = s.Contains(btn.Text) ? Color.Aqua : Color.White;
                        btn.Tag = s.Contains(btn.Text) ? btn.Text : null;
                    }
            }
        }

        // выбор зуба
        private void Select(object sender, EventArgs e)
        {
            // если нажата не кнопка зуба - выход
            if(!(sender is Button b)) return;
            // сформируем строку с выбранными зубами
            b.Tag = b.Tag == null ? b.Text : null;
            b.BackColor = b.Tag == null ? Color.White : Color.Aqua;
            _tootch = null;
            foreach (Control c in Controls)
                if (c is Button btn)
                {
                    if (btn.Tag != null)
                        _tootch += (_tootch == null ? "" : ",") + btn.Tag;
                }

            var tmp = _tootch?.Split(',')?.ToList();
            tmp?.Sort();
            _tootch = string.Join(",", (tmp != null ? tmp : new[] { "-" }.ToList()));
            // отобразим в представлении
            label2.Text = $@"[{_tootch}]";
        }

        // ок
        private void button33_Click(object sender, EventArgs e)
        {
            // созранить результат
            Result = _tootch;
            // закрыть форму
            Close();
        }

    }
}
