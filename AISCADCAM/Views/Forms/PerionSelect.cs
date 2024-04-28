using System;
using MaterialSkin.Controls;

namespace AISCADCAM.Views.Forms
{
    public partial class PerionSelect : MaterialForm
    {
        public static DateTime Start { get; set; }
        public static DateTime Finish { get; set; }
        public static bool IsSelected { get; set; }
        public PerionSelect()
        {
            InitializeComponent();
            if (Start == DateTime.MinValue) Start = DateTime.Now;
            if (Finish == DateTime.MinValue) Finish = DateTime.Now;
            monthCalendar1.SetDate(Start);
            monthCalendar1.SetDate(Finish);
            IsSelected = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Start = monthCalendar1.SelectionStart;
            Finish = monthCalendar2.SelectionStart;
            IsSelected = true;
            Close();
        }

        private void PerionSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
