namespace AISCADCAM
{
    partial class FormAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrator));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.блокироватьРазблокироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьПарольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.блокироватьРазблокироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortNo = new System.Windows.Forms.ToolStripMenuItem();
            this.sortType = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.направлениеСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDown = new System.Windows.Forms.ToolStripMenuItem();
            this.sortUp = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.восстановитьИзBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBlock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сменитьПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.блокироватьРазблокироватьToolStripMenuItem1,
            this.сброситьПарольToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 126);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.plus;
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.AddUser);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.pencil;
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.Edit_User);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(236, 6);
            // 
            // блокироватьРазблокироватьToolStripMenuItem1
            // 
            this.блокироватьРазблокироватьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.lock_break;
            this.блокироватьРазблокироватьToolStripMenuItem1.Name = "блокироватьРазблокироватьToolStripMenuItem1";
            this.блокироватьРазблокироватьToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.блокироватьРазблокироватьToolStripMenuItem1.Text = "Блокировать/Разблокировать";
            this.блокироватьРазблокироватьToolStripMenuItem1.Click += new System.EventHandler(this.BlockUser);
            // 
            // сброситьПарольToolStripMenuItem1
            // 
            this.сброситьПарольToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.textfield_password;
            this.сброситьПарольToolStripMenuItem1.Name = "сброситьПарольToolStripMenuItem1";
            this.сброситьПарольToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.сброситьПарольToolStripMenuItem1.Text = "Сбросить пароль";
            this.сброситьПарольToolStripMenuItem1.Click += new System.EventHandler(this.DropUserPassword);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(236, 6);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.Close;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.RemoteUser);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пользователяToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(985, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem1,
            this.сменитьПользователяToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(131, 40);
            this.файлToolStripMenuItem.Text = "Администратор";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.сменитьПользователяToolStripMenuItem.Text = "Выход";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пользователяToolStripMenuItem
            // 
            this.пользователяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.блокироватьРазблокироватьToolStripMenuItem,
            this.сброситьПарольToolStripMenuItem,
            this.toolStripMenuItem3,
            this.удалитьToolStripMenuItem});
            this.пользователяToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.пользователяToolStripMenuItem.Name = "пользователяToolStripMenuItem";
            this.пользователяToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.пользователяToolStripMenuItem.Text = "Пользователи";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.создатьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.create;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.AddUser);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.изменитьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.edit_ok;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.Edit_User);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(284, 6);
            // 
            // блокироватьРазблокироватьToolStripMenuItem
            // 
            this.блокироватьРазблокироватьToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.блокироватьРазблокироватьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.lock_break;
            this.блокироватьРазблокироватьToolStripMenuItem.Name = "блокироватьРазблокироватьToolStripMenuItem";
            this.блокироватьРазблокироватьToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.блокироватьРазблокироватьToolStripMenuItem.Text = "Блокировать/Разблокировать";
            this.блокироватьРазблокироватьToolStripMenuItem.Click += new System.EventHandler(this.BlockUser);
            // 
            // сброситьПарольToolStripMenuItem
            // 
            this.сброситьПарольToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan;
            this.сброситьПарольToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.textfield_password;
            this.сброситьПарольToolStripMenuItem.Name = "сброситьПарольToolStripMenuItem";
            this.сброситьПарольToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.сброситьПарольToolStripMenuItem.Text = "Сбросить пароль";
            this.сброситьПарольToolStripMenuItem.Click += new System.EventHandler(this.DropUserPassword);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(284, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.trash;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.RemoteUser);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortNo,
            this.sortType,
            this.sortDate,
            this.toolStripMenuItem4,
            this.направлениеСортировкиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(104, 40);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // sortNo
            // 
            this.sortNo.Checked = true;
            this.sortNo.CheckOnClick = true;
            this.sortNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortNo.ForeColor = System.Drawing.Color.White;
            this.sortNo.Name = "sortNo";
            this.sortNo.Size = new System.Drawing.Size(259, 24);
            this.sortNo.Tag = "0";
            this.sortNo.Text = "Без сортировки";
            this.sortNo.Click += new System.EventHandler(this.SortGrid);
            // 
            // sortType
            // 
            this.sortType.ForeColor = System.Drawing.Color.White;
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(259, 24);
            this.sortType.Tag = "1";
            this.sortType.Text = "По типу учётной записи";
            this.sortType.Click += new System.EventHandler(this.SortGrid);
            // 
            // sortDate
            // 
            this.sortDate.ForeColor = System.Drawing.Color.White;
            this.sortDate.Name = "sortDate";
            this.sortDate.Size = new System.Drawing.Size(259, 24);
            this.sortDate.Tag = "2";
            this.sortDate.Text = "По дате регистрации";
            this.sortDate.Click += new System.EventHandler(this.SortGrid);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(256, 6);
            // 
            // направлениеСортировкиToolStripMenuItem
            // 
            this.направлениеСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortDown,
            this.sortUp});
            this.направлениеСортировкиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.направлениеСортировкиToolStripMenuItem.Name = "направлениеСортировкиToolStripMenuItem";
            this.направлениеСортировкиToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.направлениеСортировкиToolStripMenuItem.Text = "Направление сортировки";
            // 
            // sortDown
            // 
            this.sortDown.Checked = true;
            this.sortDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortDown.ForeColor = System.Drawing.Color.White;
            this.sortDown.Name = "sortDown";
            this.sortDown.Size = new System.Drawing.Size(194, 24);
            this.sortDown.Text = "По возрастанию";
            this.sortDown.Click += new System.EventHandler(this.SortGrid);
            // 
            // sortUp
            // 
            this.sortUp.ForeColor = System.Drawing.Color.White;
            this.sortUp.Name = "sortUp";
            this.sortUp.Size = new System.Drawing.Size(194, 24);
            this.sortUp.Text = "По убыванию";
            this.sortUp.Click += new System.EventHandler(this.SortGrid);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьBackupToolStripMenuItem,
            this.восстановитьИзBackupToolStripMenuItem});
            this.администрированиеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(168, 40);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // создатьBackupToolStripMenuItem
            // 
            this.создатьBackupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.создатьBackupToolStripMenuItem.Name = "создатьBackupToolStripMenuItem";
            this.создатьBackupToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.создатьBackupToolStripMenuItem.Text = "Создать backup";
            this.создатьBackupToolStripMenuItem.Click += new System.EventHandler(this.создатьBackupToolStripMenuItem_Click);
            // 
            // восстановитьИзBackupToolStripMenuItem
            // 
            this.восстановитьИзBackupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.восстановитьИзBackupToolStripMenuItem.Name = "восстановитьИзBackupToolStripMenuItem";
            this.восстановитьИзBackupToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.восстановитьИзBackupToolStripMenuItem.Text = "Восстановить из backup";
            this.восстановитьИзBackupToolStripMenuItem.Click += new System.EventHandler(this.восстановитьИзBackupToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 40);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Famile,
            this.Date,
            this.Login,
            this.IsBlock,
            this.Type});
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(0, 100);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowCellErrors = false;
            this.grid.ShowCellToolTips = false;
            this.grid.ShowEditingIcon = false;
            this.grid.ShowRowErrors = false;
            this.grid.Size = new System.Drawing.Size(985, 434);
            this.grid.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Famile
            // 
            this.Famile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Famile.DataPropertyName = "Fio";
            this.Famile.HeaderText = "Фамилия Имя Отчество";
            this.Famile.Name = "Famile";
            this.Famile.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy hh:mm";
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.HeaderText = "Зарегистрирован";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 155;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // IsBlock
            // 
            this.IsBlock.DataPropertyName = "IsBlock";
            this.IsBlock.FalseValue = "false";
            this.IsBlock.HeaderText = "Блокирован";
            this.IsBlock.IndeterminateValue = "false";
            this.IsBlock.Name = "IsBlock";
            this.IsBlock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsBlock.TrueValue = "true";
            this.IsBlock.Width = 110;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            // 
            // сменитьПользователяToolStripMenuItem1
            // 
            this.сменитьПользователяToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.сменитьПользователяToolStripMenuItem1.Name = "сменитьПользователяToolStripMenuItem1";
            this.сменитьПользователяToolStripMenuItem1.Size = new System.Drawing.Size(238, 24);
            this.сменитьПользователяToolStripMenuItem1.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem1.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem1_Click);
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(985, 534);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdministrator";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            this.Load += new System.EventHandler(this.FormAdministrator_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem сброситьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блокироватьРазблокироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem пользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortNo;
        private System.Windows.Forms.ToolStripMenuItem sortType;
        private System.Windows.Forms.ToolStripMenuItem sortDate;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem восстановитьИзBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem направлениеСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDown;
        private System.Windows.Forms.ToolStripMenuItem sortUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem блокироватьРазблокироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сброситьПарольToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
    }
}