using AISCADCAM.Core;
using AISCADCAM.Properties;
using AISCADCAM.Views.UControls;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace AISCADCAM
{
    /// <summary> Главная форма специалиста </summary>
    public partial class FormSpecialist : MaterialForm
    {
        public FormSpecialist()
        {
            // заполнит ьданными элементы формы
            InitializeComponent();
            Text = $"{Settings.Default.ProductName} [" +
                   $"{Instance.CurrentUser.FioSmall}/" +
                   $"{Instance.CurrentUser.Type}]";
        }
        private void FormSpecialist_Load(object sender, EventArgs e) => menuStrip1.Renderer = new ToolStripProfessionalRenderer(new StyleMenu());
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instance.CurrentUser = null;
            Close();
        }
        private void ToReport(object sender, EventArgs e) => new FormReports { Owner = this }.ShowDialog(this);
        private void NoSort(object sender, EventArgs e) => gridOrderFilter1.SetSert(GridOrderFilter.EGridSort.sortNo);
        private void SortDate(object sender, EventArgs e) => gridOrderFilter1.SetSert(GridOrderFilter.EGridSort.sortDate);
        private void SortPatient(object sender, EventArgs e) => gridOrderFilter1.SetSert(GridOrderFilter.EGridSort.sortPatient);
        private void SortMaterial(object sender, EventArgs e) => gridOrderFilter1.SetSert(GridOrderFilter.EGridSort.sortMat);
        private void SortUser(object sender, EventArgs e) => gridOrderFilter1.SetSert(GridOrderFilter.EGridSort.sortUser);
        private void SortUp(object sender, EventArgs e) => gridOrderFilter1.SortDown = false;
        private void SortDown(object sender, EventArgs e) => gridOrderFilter1.SortDown = true;
        private void AddItem(object sender, EventArgs e) => gridOrderFilter1.Create(sender, e);
        private void ChangeItem(object sender, EventArgs e) => gridOrderFilter1.Change(sender, e);
        private void DelItem(object sender, EventArgs e) => gridOrderFilter1.Delete(sender, e);
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new FormAbout { Owner = this }.ShowDialog(this);
        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e) => Close();
    }
}
