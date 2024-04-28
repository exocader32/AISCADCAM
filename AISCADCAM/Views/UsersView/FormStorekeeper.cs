using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using AISCADCAM.Core;
using AISCADCAM.Properties;
using System.Windows.Forms;
using AISCADCAM.Models;
using MaterialSkin.Controls;

namespace AISCADCAM
{
    /// <summary> главная форма завсклада </summary>
    public partial class FormStorekeeper : MaterialForm
    {
        private DataGridView grid = null;
        public FormStorekeeper()
        {
            // заполнить данные элементов формы
            InitializeComponent();
            Text = $"{Settings.Default.ProductName} [" +
                   $"{Instance.CurrentUser.FioSmall}/" +
                   $"{Instance.CurrentUser.Type}]";
        }

        private void FormStorekeeper_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new StyleMenu());
            // заполнить таблицы
            gridMaterial.AutoGenerateColumns = gridBlock.AutoGenerateColumns = gridModel.AutoGenerateColumns = false;
            gridMaterial.DataSource = Instance.DB.Materials.ToList();
            gridBlock.DataSource = Instance.DB.Blocks.ToList();
            gridModel.DataSource = Instance.DB.Models.ToList();
            grid_MouseDown(gridMaterial,null);
        }

        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new FormAbout { Owner = this }.ShowDialog(this);
        // отчеты
        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e) => new FormReports { Owner = this }.ShowDialog(this);
        // обработка ПКМ
        private void grid_MouseDown(object sender, MouseEventArgs e)
        {
            grid = (DataGridView)sender;
            if(grid==null) return;
            if (grid!=null && e?.Button == MouseButtons.Right)
            {
                var hti = grid.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    grid.ClearSelection();
                    grid.Rows[hti.RowIndex].Selected = true;
                }
            }

            //if (grid?.Tag != null)
            //{
            //    var l = new[] { label1, label2, label3 };
            //    for (var i = 0; i < l.Length; i++)
            //    {
            //        l[i].BackColor = i == int.Parse(grid.Tag.ToString())?SystemColors.ActiveCaption:SystemColors.Control;
            //    }
            //}
        }
        // обновление таблиц
        private void UpdateSource(int i)
        {
            switch (i)
            {
                case 0: gridMaterial.DataSource = null;
                        gridMaterial.DataSource = Instance.DB.Materials.ToList();
                        break;
                case 1: gridBlock.DataSource = null;
                        gridBlock.DataSource = Instance.DB.Blocks.ToList();
                        break;
                case 2: gridModel.DataSource = null;
                        gridModel.DataSource = Instance.DB.Models.ToList();
                        break;
            }
        }
        // создание записи
        private void Create(object sender, EventArgs e)
        {
            if(grid?.Tag==null && grid.SelectedCells.Count==0) return;
            var l = new[] { label1, label2, label3 };
            var value = "";
            int i = int.Parse(grid.Tag?.ToString() ?? "0");
            // подобрать склонение для формы создания записи
            var type = l[i].Text;
            type = type.Substring(0, type.Length - 1);
            switch (i)
            {

                case 0: case 1: type += "А"; break;
                case 2: type += "Ь"; break;
            }
            float price = -1;
            if (i==0) price = float.Parse(grid.SelectedCells[2].Value.ToString());
            // открыть форму создания наименования
            new EditName(type, value, price) { Owner = this }.ShowDialog(this);
            if(EditName.Value==null) return;
            // записать в бд
            switch (i)
            {
                case 0: Instance.DB.Materials.Add(new Material(EditName.Value, EditName.Price));
                    Instance.DB.Stocks.Add(new Stock(EditName.Value) { Type = nameof(Material), Count = 1000 });
                    break;
                case 1: Instance.DB.Blocks.Add(new Block(EditName.Value));
                    Instance.DB.Stocks.Add(new Stock(EditName.Value) { Type = nameof(Block), Count = 1000 });
                    break;
                case 2: Instance.DB.Models.Add(new Model(EditName.Value)); 
                    Instance.DB.Stocks.Add(new Stock(EditName.Value) { Type = nameof(Model), Count = 1000 });
                    break;
            }
            // сохранить изменения в бд
            Instance.DB.SaveChanges();
            UpdateSource(i);
        }
        // изменение записи
        private void Change(object sender, EventArgs e)
        {
            if(grid?.Tag==null && grid.SelectedCells.Count==0) return;
            var l = new[] { label1, label2, label3 };
            int i = int.Parse(grid.Tag?.ToString() ?? "0");
            var value = grid.SelectedCells[1].Value.ToString();
            var type = l[i].Text;
            type = type.Substring(0, type.Length - 1);
            switch (i)
            {

                case 0: case 1: type += "А"; break;
                case 2: type += "Ь"; break;
            }
            float price = -1;
            int count = int.Parse(grid.SelectedCells[grid.SelectedCells.Count - 1].Value.ToString());
            if (count < 0) count = 0;
            if (grid?.Tag?.ToString() == "0") price = float.Parse(grid.SelectedCells[2].Value.ToString());
            new EditName(type,value,price,count) { Owner = this }.ShowDialog(this);
            if(EditName.Value==null) return;
            switch (i)
            {
                case 0:
                    var item = ((List<Material>)grid.DataSource)[grid.SelectedCells[0].RowIndex];
                    item.Name = EditName.Value;
                    item.Price = EditName.Price<0?0:EditName.Price;
                    var stock = Instance.DB.Stocks.FirstOrDefault(s => s.Name == item.Name && s.Type == nameof(Material));
                    if (stock == null)
                    {
                        stock = new Stock(item.Name) { Type = nameof(Material), Count = 0 };
                        stock = Instance.DB.Stocks.Add(stock);
                        Instance.DB.SaveChanges();
                    }
                    stock.Count = EditName.Count;
                    Instance.DB.Materials.AddOrUpdate(item);
                    break;
                case 1: 
                    var item1 = ((List<Block>)grid.DataSource)[grid.SelectedCells[0].RowIndex];
                    item1.Name = EditName.Value;
                    var stock1 = Instance.DB.Stocks.FirstOrDefault(s => s.Name == item1.Name && s.Type == nameof(Block));
                    if (stock1 == null)
                    {
                        stock1 = new Stock(item1.Name) { Type = nameof(Block), Count = 0 };
                        stock1 = Instance.DB.Stocks.Add(stock1);
                        Instance.DB.SaveChanges();
                    }
                    stock1.Count = EditName.Count;
                    Instance.DB.Blocks.AddOrUpdate(item1);
                    break;
                case 2:
                    var item2 = ((List<Model>)grid.DataSource)[grid.SelectedCells[0].RowIndex];
                    item2.Name = EditName.Value;
                    var stock2 = Instance.DB.Stocks.FirstOrDefault(s => s.Name == item2.Name && s.Type == nameof(Model));
                    if (stock2 == null)
                    {
                        stock2 = new Stock(item2.Name) { Type = nameof(Model), Count = 0 };
                        stock2 = Instance.DB.Stocks.Add(stock2);
                        Instance.DB.SaveChanges();
                    }
                    stock2.Count = EditName.Count;
                    Instance.DB.Models.AddOrUpdate(item2);
                    break;
            }
            Instance.DB.SaveChanges();
            UpdateSource(i);
        }
        // удаление записи
        private void Remote(object sender, EventArgs e)
        {
            if (grid?.Tag == null && grid.SelectedCells.Count == 0) return;
            var value = grid.SelectedCells[1].Value.ToString();
            int index = int.Parse(grid.Tag?.ToString() ?? "0");
            var type = new[]{ label1, label2, label3 }[index].Text;
            type = type.Substring(0, type.Length - 1);
            if (MessageBox.Show($"Удалить {type} - '{value}'?","Внимание", MessageBoxButtons.YesNo)!=DialogResult.Yes) return;
            var stock = Instance.DB.Stocks.FirstOrDefault(s => s.Name == value);
            if(stock!=null)
                Instance.DB.Stocks.Remove(stock);
            switch (index)
            {
                case 0: Instance.DB.Materials.Remove(((List<Material>)grid.DataSource)?[grid.SelectedCells[0].RowIndex]); break;
                case 1: Instance.DB.Blocks.Remove(((List<Block>)grid.DataSource)?[grid.SelectedCells[0].RowIndex]); break;
                case 2: Instance.DB.Models.Remove(((List<Model>)grid.DataSource)?[grid.SelectedCells[0].RowIndex]); break;
            }
            Instance.DB.SaveChanges();
            UpdateSource(index);
        }
        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e) { grid = gridMaterial; Create(toolStripMenuItem5,e); }
        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e) { grid = gridMaterial; Change(toolStripMenuItem6,e); }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e) { grid = gridMaterial; Remote(toolStripMenuItem7,e); }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) { grid = gridBlock; Create(toolStripMenuItem5,e); }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e) { grid = gridBlock; Change(toolStripMenuItem6,e); }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) { grid = gridBlock; Remote(toolStripMenuItem7,e); }
        private void создатьToolStripMenuItem2_Click(object sender, EventArgs e) { grid = gridModel; Create(toolStripMenuItem5,e); }
        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e) { grid = gridModel; Change(toolStripMenuItem6,e); }
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e) { grid = gridModel; Remote(toolStripMenuItem7,e); }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instance.CurrentUser = null;
            Close();
        }
        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
