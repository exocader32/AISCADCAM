using System;
using System.Linq;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Properties;

namespace AISCADCAM
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            Text = $"{Settings.Default.ProductName} [" +
                   $"{Instance.CurrentUser.FioSmall}/" +
                   $"{Instance.CurrentUser.Type}]";
            grid.AutoGenerateColumns = false;
            grid.DataSource = Instance.DB.Orders.ToList().Select(o => o.ToGrid()).ToList();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new FormAbout { Owner = this }.ShowDialog(this);
        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e) => new FormReports { Owner = this }.ShowDialog(this);
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instance.CurrentUser = null;
            Close();
        }
        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
