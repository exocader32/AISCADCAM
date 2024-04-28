namespace AISCADCAM
{
    partial class FormSotrudnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSotrudnik));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortNo = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDate = new System.Windows.Forms.ToolStripMenuItem();
            this.sortMat = new System.Windows.Forms.ToolStripMenuItem();
            this.sortUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.направлениеСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDown = new System.Windows.Forms.ToolStripMenuItem();
            this.sortUp = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьБлокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOrderFilter1 = new AISCADCAM.Views.UControls.GridOrderFilter();
            this.сменитьПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1058, 37);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem1,
            this.сменитьПользователяToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.файлToolStripMenuItem.Text = "Сотрудник";
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
            this.удалитьToolStripMenuItem});
            this.пользователяToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.пользователяToolStripMenuItem.Name = "пользователяToolStripMenuItem";
            this.пользователяToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.пользователяToolStripMenuItem.Text = "Заказы";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.создатьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.create;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.AddItem);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.изменитьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.edit_ok;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ChangeItem);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.trash;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DelItem);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortNo,
            this.sortDate,
            this.sortMat,
            this.sortUser,
            this.toolStripMenuItem4,
            this.направлениеСортировкиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
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
            this.sortNo.Click += new System.EventHandler(this.NoSort);
            // 
            // sortDate
            // 
            this.sortDate.ForeColor = System.Drawing.Color.White;
            this.sortDate.Name = "sortDate";
            this.sortDate.Size = new System.Drawing.Size(259, 24);
            this.sortDate.Tag = "1";
            this.sortDate.Text = "По дате";
            this.sortDate.Click += new System.EventHandler(this.SortDate);
            // 
            // sortMat
            // 
            this.sortMat.ForeColor = System.Drawing.Color.White;
            this.sortMat.Name = "sortMat";
            this.sortMat.Size = new System.Drawing.Size(259, 24);
            this.sortMat.Tag = "2";
            this.sortMat.Text = "По материалу";
            this.sortMat.Click += new System.EventHandler(this.SortMaterial);
            // 
            // sortUser
            // 
            this.sortUser.ForeColor = System.Drawing.Color.White;
            this.sortUser.Name = "sortUser";
            this.sortUser.Size = new System.Drawing.Size(259, 24);
            this.sortUser.Tag = "3";
            this.sortUser.Text = "По заказчику";
            this.sortUser.Click += new System.EventHandler(this.SortUser);
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
            this.sortDown.Click += new System.EventHandler(this.SortDown);
            // 
            // sortUp
            // 
            this.sortUp.ForeColor = System.Drawing.Color.White;
            this.sortUp.Name = "sortUp";
            this.sortUp.Size = new System.Drawing.Size(194, 24);
            this.sortUp.Text = "По убыванию";
            this.sortUp.Click += new System.EventHandler(this.SortUp);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.администрированиеToolStripMenuItem.Text = "Отчёты";
            this.администрированиеToolStripMenuItem.Click += new System.EventHandler(this.ToReport);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.изменитьБлокToolStripMenuItem,
            this.toolStripMenuItem5,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 98);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.plus;
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.создатьToolStripMenuItem1.Text = "Создать";
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.pencil;
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // изменитьБлокToolStripMenuItem
            // 
            this.изменитьБлокToolStripMenuItem.Image = global::AISCADCAM.Properties.Resources.pencil;
            this.изменитьБлокToolStripMenuItem.Name = "изменитьБлокToolStripMenuItem";
            this.изменитьБлокToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.изменитьБлокToolStripMenuItem.Text = "Изменить блок";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(155, 6);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::AISCADCAM.Properties.Resources.Close;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // gridOrderFilter1
            // 
            this.gridOrderFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.gridOrderFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOrderFilter1.Location = new System.Drawing.Point(0, 97);
            this.gridOrderFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.gridOrderFilter1.Name = "gridOrderFilter1";
            this.gridOrderFilter1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gridOrderFilter1.Size = new System.Drawing.Size(1058, 385);
            this.gridOrderFilter1.SortDown = false;
            this.gridOrderFilter1.TabIndex = 5;
            // 
            // сменитьПользователяToolStripMenuItem1
            // 
            this.сменитьПользователяToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.сменитьПользователяToolStripMenuItem1.Name = "сменитьПользователяToolStripMenuItem1";
            this.сменитьПользователяToolStripMenuItem1.Size = new System.Drawing.Size(238, 24);
            this.сменитьПользователяToolStripMenuItem1.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem1.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem1_Click);
            // 
            // FormSotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 482);
            this.Controls.Add(this.gridOrderFilter1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSotrudnik";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSotrudnik";
            this.Load += new System.EventHandler(this.FormSpecialist_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortNo;
        private System.Windows.Forms.ToolStripMenuItem sortDate;
        private System.Windows.Forms.ToolStripMenuItem sortMat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem направлениеСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDown;
        private System.Windows.Forms.ToolStripMenuItem sortUp;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьБлокToolStripMenuItem;
        private Views.UControls.GridOrderFilter gridOrderFilter1;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
    }
}