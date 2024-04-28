using System;
using System.Linq;
using AISCADCAM.Core;
using AISCADCAM.Models;
using System.Windows.Forms;
using AISCADCAM.Properties;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace AISCADCAM
{
    /// <summary> главная форма Администратора </summary>
    public partial class FormAdministrator : MaterialForm
    {
        public FormAdministrator()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            // заполнить данными элементы формы
            Text = $"{Settings.Default.ProductName} [" +
                   $"{Instance.CurrentUser.FioSmall}/" +
                   $"{Instance.CurrentUser.Type}]";
            grid.AutoGenerateColumns = false;
            grid.DataSource = Instance.DB.Users.ToList();
            grid.CellClick += grid_CellClick;
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new StyleMenu());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instance.CurrentUser = null;
            Close();
        }

        private void SortGrid(object sender, EventArgs e)
        {
            // отределение типа сортировки
            ToolStripMenuItem tsmi = null;
            if (sender is ToolStripMenuItem)
                    tsmi = (ToolStripMenuItem)sender;
            if (tsmi == null)
            {
                sender = sortNo.Checked ? sortNo : (sortType.Checked ? sortType : sortDate);
                if (sender is ToolStripMenuItem strmenu)
                    tsmi = strmenu;
                else tsmi = sortNo;
            }
            // все записи пользователей из бд
            var table = Instance.DB.Users.ToList();
            tsmi.Checked = true;
            if (tsmi.Tag != null)
            {
                foreach (ToolStripMenuItem item in new[] { sortNo, sortDate, sortType }) item.Checked = tsmi == item;
                // сотрировка
                switch (tsmi.Tag.ToString())
                {
                    case "1": table = table.OrderBy(u => u.Type).ToList(); break;
                    case "2": table = table.OrderBy(u => u.Date).ToList(); break;
                }
            }
            else
                foreach (ToolStripMenuItem item in new[] { sortDown, sortUp }) item.Checked = tsmi == item;
            // в обратном направлении (иначе в прямом)
            if (!sortDown.Checked) table.Reverse();
            grid.DataSource = table;
        }

        // создание бакапа
        private void создатьBackupToolStripMenuItem_Click(object sender, EventArgs e) => Instance.DB.Backup();

        // восстановление из бакапа
        private void восстановитьИзBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog
            {
                Title = @"Укажите файл бакапа для восстановления...",
                InitialDirectory = $"{Application.StartupPath}\\Backup\\",
                Filter = @"BACKUP MSSQLDB|*.bak",
            };
            if (f.ShowDialog() != DialogResult.OK) return;
            Instance.DB.Restore(f.FileName);
            SortGrid(sender, e);
        }

        #region button user

        private void AddUser(object sender, EventArgs e)
        {
            new EditUser(new User()) { Owner = this }.ShowDialog(this);
            if (EditUser.Result == null) return;
            SortGrid(sender, e);
        }


        private void Edit_User(object sender, EventArgs e)
        {
            if (grid.SelectedCells == null) return;
            int index = grid.SelectedCells[0].RowIndex;
            if (index < 0) return;
            new EditUser(((List<User>)grid.DataSource)[index]) { Owner = this }.ShowDialog(this);
            if (EditUser.Result == null) return;
            SortGrid(sender, e);
        }

        private void BlockUser(object sender, EventArgs e)
        {
            if (grid.SelectedCells == null) return;
            int index = grid.SelectedCells[0].RowIndex;
            if (index < 0) return;
            var var = ((List<User>)grid.DataSource)[index];
            if (var == null) return;
            var.IsBlock = !var.IsBlock;
            Instance.DB.Users.AddOrUpdate(var);
            Instance.DB.SaveChanges();
            SortGrid(sender, e);
        }

        private void DropUserPassword(object sender, EventArgs e)
        {
            if (grid.SelectedCells == null) return;
            int index = grid.SelectedCells[0].RowIndex;
            if (index < 0) return;
            var var = ((List<User>)grid.DataSource)[index];
            if (var == null) return;
            var.Password = "";
            Instance.DB.Users.AddOrUpdate(var);
            Instance.DB.SaveChanges();
            SortGrid(sender, e);
        }

        private void RemoteUser(object sender, EventArgs e)
        {
            if (grid.SelectedCells == null) return;
            int index = grid.SelectedCells[0].RowIndex;
            if (index < 0) return;
            var var = ((List<User>)grid.DataSource)[index];
            if (var == null) return;
            var.Password = "";
            Instance.DB.Users.Remove(var);
            Instance.DB.SaveChanges();
            SortGrid(sender, e);
        }

        #endregion

        // обработка блокировки или разблокировки пользователя из таблицы
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
                BlockUser(sender, e);
        }

        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new FormAbout { Owner = this }.ShowDialog(this);

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
