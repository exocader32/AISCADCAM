using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace AISCADCAM
{
    /// <summary> форма с информацией О Программе </summary>
    public partial class FormAbout : MaterialForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        // закрытие окна
        private void FormAbout_Click(object sender, EventArgs e) => Close();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) => Close();

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
