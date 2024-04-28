using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AISCADCAM.Models;

namespace AISCADCAM.UControls
{
    public partial class FindOrder : UserControl
    {
        public event EventHandler FilterChanged;
        public FindOrder()
        {
            InitializeComponent();
        }

        // очистка всех полей
        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = string.Empty;
            FilterChanged?.Invoke(this, e);
        }

        public List<OrderGrid> Filter(List<OrderGrid> list)
        {
            List<OrderGrid> ret = new List<OrderGrid>();
            foreach (OrderGrid o in list)
            {
                OrderGrid tmp = null;
                var ch = new[]
                {
                    !string.IsNullOrWhiteSpace(txt1.Text),
                    !string.IsNullOrWhiteSpace(txt2.Text),
                    !string.IsNullOrWhiteSpace(txt3.Text),
                    !string.IsNullOrWhiteSpace(txt4.Text),
                    !string.IsNullOrWhiteSpace(txt5.Text),
                    !string.IsNullOrWhiteSpace(txt6.Text),
                };
                if (!ch.Contains(true))
                {
                    ret.Add(o);
                    continue;
                }
                if (ch[0] && o.Patient.ToLower().Contains(txt1.Text.ToLower()))
                    tmp = o;
                if (ch[1] && o.ToothNumbers.ToLower().Contains(txt2.Text.ToLower()))
                    tmp = o;
                if (ch[2] && o.Material.ToLower().Contains(txt3.Text.ToLower()))
                    tmp = o;
                if (ch[3] && o.Color.ToLower().Contains(txt4.Text.ToLower()))
                    tmp = o;
                if (ch[4] && o.Size.ToLower().Contains(txt5.Text.ToLower()))
                    tmp = o;
                if (ch[5] && o.User.ToLower().Contains(txt6.Text.ToLower()))
                    tmp = o;
                if(tmp != null) ret.Add(tmp);
            }
            return ret;
        }

        private void txt1_TextChanged(object sender, EventArgs e) => FilterChanged?.Invoke(this,e);
    }
}
