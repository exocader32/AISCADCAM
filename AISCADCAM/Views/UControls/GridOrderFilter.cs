using System;
using System.Linq;
using AISCADCAM.Core;
using AISCADCAM.Models;
using System.Windows.Forms;
using MaterialSkin.Controls;
using AISCADCAM.Views.Forms;
using AISCADCAM.Views.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace AISCADCAM.Views.UControls
{
    public partial class GridOrderFilter : UserControl
    {
        private int tsmiTag = 0;
        private bool sortNo = true, sortDate = false, sortMat = false, sortPatient = false, sortUser = false;
        private bool _sortDown;
        private OrderGrid currGrid = null;
        private bool issort = false;

        public bool ShowStatus
        {
            set
            {
                status.Visible = value;
                payment.Visible = topay.Visible = discount.Visible = !value;
            }
        } 

        public bool SortDown
        {
            get => _sortDown;
            set
            {
                _sortDown = value;
                if (Instance.IsRunning) SortClicks(null, null);
            }
        }

        public GridOrderFilter()
        {
            InitializeComponent();
            SetSert(EGridSort.sortNo);
            grid.AutoGenerateColumns = false;
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (Instance.IsRunning)
            {
                grid.DataSource = Instance.DB?.Orders?.ToList()?.Select(o => o.ToGrid())?.ToList() ?? null;
                SortDown = false;
            }
        }

        #region change Order

        // создание записи в отдельном окне
        public void Create(object sender, EventArgs e)
        {
            new EditOrder(new Order()) { Owner = (MaterialForm)this.Parent }.ShowDialog(this);
            if (EditOrder.Result != null) SortClicks(sender, e);
        }

        // изменение записи в отдельном окне
        public void Change(object sender, EventArgs e)
        {
            if (grid.SelectedCells?.Count == 0) return;
            var id = (((List<OrderGrid>)grid.DataSource)[grid.SelectedCells[0].RowIndex])?.Id;
            Order o = Instance.DB.Orders.FirstOrDefault(or => or.Id == id);
            if (o == null) return;
            new EditOrder(o) { Owner = (MaterialForm)this.Parent }.ShowDialog(this);
            if (EditOrder.Result != null) SortClicks(sender, e);
        }

        // удаление записи
        public void Delete(object sender, EventArgs e)
        {
            if (grid.SelectedCells?.Count == 0) return;
            int id = (((List<OrderGrid>)grid.DataSource)[grid.SelectedCells[0].RowIndex]).Id;
            Order o = Instance.DB.Orders.FirstOrDefault(oor => oor.Id == id);
            if (o == null) return;
            if (MessageBox.Show("Удалить заказ?", "Внимание!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Instance.DB.Orders.Remove(o);
            Instance.DB.SaveChanges();
            SortClicks(sender, e);
        }

        #endregion

        public void grid_MouseDown(object sender, MouseEventArgs e)
        {
            // обработка ПКМ на таблице - сменить выделение
            if (e.Button == MouseButtons.Right)
            {
                var hti = grid.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    grid.ClearSelection();
                    grid.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        public event EventHandler<DataGridViewCellMouseEventArgs> ColumnHeaderMouseClick;

        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColumnHeaderMouseClick?.Invoke(sender, e);
            var col = grid.Columns[e.ColumnIndex];
            txt1.Hint = col.HeaderText;
            switch (col.DataPropertyName)
            {
                case "Patient": 
                    if (sortPatient) SortDown = !SortDown;
                    else SetSert(EGridSort.sortPatient);
                    break;
                case "User": 
                    if (sortUser) SortDown = !SortDown;
                    else SetSert(EGridSort.sortUser); 
                    break;
                case "Blank": 
                    if (sortMat) SortDown = !SortDown;
                    else SetSert(EGridSort.sortMat);
                    break;
                default: ClearFilter(sender, e); break;
            }
        }
       
        // очистка фильтра
        private void ClearFilter(object sender, EventArgs e)
        {
            issort = _sortDown = false;
            txt1.Text = txt1.Hint = "";
            SetSert(EGridSort.sortNo);
        }

        // нажатие кнопки ОК - сохранение комментария в выделенный заказ
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (currGrid != null)
            {
                var item = Instance.DB.Orders?.FirstOrDefault(o => o.Id == currGrid.Id);
                if (item != null && item.Commentary!=textBox1.Text && !issort)
                {
                    item.Commentary = textBox1.Text;
                    Instance.DB.Orders.AddOrUpdate(item);
                    Instance.DB.SaveChanges();
                    OrderGrid og=((List<OrderGrid>)grid.DataSource).FirstOrDefault(f=>f.Id==item.Id);
                    if (og != null) 
                        og.Commentary = textBox1.Text;
                }
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if(issort) return;
            issort = true;
            materialFlatButton1_Click(sender,e);
            if (grid.SelectedCells.Count > 0)
            {
                var index = grid.SelectedCells[0].RowIndex;
                currGrid = ((List<OrderGrid>)grid.DataSource)[index];
                textBox1.Text = currGrid?.Commentary;
            }
            else textBox1.Text = "";
            //SortClicks(sender,e);
            issort = false;
        }

        public void SetSert(EGridSort sort)
        {
            _sortDown = false;
            sortNo = true;
            sortDate = sortMat = sortPatient = sortUser = false;
            switch (sort)
            {
                case EGridSort.sortNo: sortNo = true; tsmiTag = 0; break;
                case EGridSort.sortDate: sortNo = false; sortDate = true; tsmiTag = 1; break;
                case EGridSort.sortMat: sortNo = false; sortMat = true; tsmiTag = 2; break;
                case EGridSort.sortPatient: sortNo = false; sortPatient = true; tsmiTag = 3; break;
                case EGridSort.sortUser: sortNo = false; sortUser = true; tsmiTag = 4; break;
            }
        }
     
        public enum EGridSort
        {
            sortNo,
            sortDate,
            sortMat,
            sortPatient,
            sortUser,
        }
     
        // сортировка по указанным параметрам
        public void SortClicks(object sender, EventArgs e)
        {
            int id = 0;
            if (grid.SelectedCells?.Count > 0) id = (int)grid.SelectedCells[0].RowIndex;

            var table = Instance.DB?.Orders?.ToList();
            lallCount.Text = table?.Count.ToString();
            if (PerionSelect.IsSelected)
                table = table?
                    .Where(t => PerionSelect.Start <= t.Create && t.Create <= PerionSelect.Finish)?
                    .ToList();

            // сотрировка
            switch (tsmiTag)
            {
                case 1: table = table.OrderBy(u => u.Create).ToList(); break;
                case 2: table = table.OrderBy(u => u.Blank?.Material?.Name).ToList(); break;
                case 3: table = table.OrderBy(u => u.Client.Fio).ToList(); break;
                case 4: table = table.OrderBy(u => u.Patient.Fio).ToList(); break;
            }
            if (txt1.Text != "")
                switch (tsmiTag)
                {
                    case 1: table = table.OrderBy(u => u.Create).ToList(); break;
                    case 2: table = table.Where(u => u.Blank?.Material?.Name?.Contains(txt1.Text) ?? false).ToList(); break;
                    case 3: table = table.Where(u => u.Patient.Fio.Contains(txt1.Text)).ToList(); break;
                    case 4: table = table.Where(u => u.Client.Fio.Contains(txt1.Text)).ToList(); break;
                    default: break;
                }

            // в обратном порядке (иначе в прямом)
            if (!SortDown) table?.Reverse();
            lcurrCount.Text = table?.Count.ToString();
            grid.DataSource = table?.Select(o => o.ToGrid())?.ToList();
            if (id > 0)
                grid.Rows[id].Selected = true;
        }

    }
}
