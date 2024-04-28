namespace AISCADCAM
{
    partial class EditUser
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
            AISCADCAM.Properties.Settings settings1 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings2 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings3 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings4 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings5 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings6 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings7 = new AISCADCAM.Properties.Settings();
            AISCADCAM.Properties.Settings settings8 = new AISCADCAM.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.fam = new System.Windows.Forms.TextBox();
            this.title1 = new AISCADCAM.Views.UControls.Title();
            this.nam = new System.Windows.Forms.TextBox();
            this.title2 = new AISCADCAM.Views.UControls.Title();
            this.lnam = new System.Windows.Forms.TextBox();
            this.title3 = new AISCADCAM.Views.UControls.Title();
            this.login = new System.Windows.Forms.TextBox();
            this.title4 = new AISCADCAM.Views.UControls.Title();
            this.pass = new System.Windows.Forms.TextBox();
            this.title5 = new AISCADCAM.Views.UControls.Title();
            this.title6 = new AISCADCAM.Views.UControls.Title();
            this.type = new System.Windows.Forms.ComboBox();
            this.title7 = new AISCADCAM.Views.UControls.Title();
            this.dat = new System.Windows.Forms.DateTimePicker();
            this.block = new System.Windows.Forms.CheckBox();
            this.title8 = new AISCADCAM.Views.UControls.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fam
            // 
            this.fam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fam.Location = new System.Drawing.Point(126, 25);
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(268, 26);
            this.fam.TabIndex = 4;
            this.fam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings1.Background = System.Drawing.SystemColors.Control;
            settings1.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings1.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings1.CommentForeSub = System.Drawing.Color.Gray;
            settings1.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings1.ProductNameLitle = "АИС CAD/CAM";
            settings1.SettingsKey = "";
            this.title1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title1.ForeColor = System.Drawing.Color.Gray;
            this.title1.Location = new System.Drawing.Point(12, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(115, 26);
            this.title1.TabIndex = 3;
            this.title1.TitleText = "ФАМИЛИЯ";
            this.title1.TitleTextSub = "";
            // 
            // nam
            // 
            this.nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nam.Location = new System.Drawing.Point(126, 57);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(268, 26);
            this.nam.TabIndex = 6;
            this.nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings2.Background = System.Drawing.SystemColors.Control;
            settings2.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings2.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings2.CommentForeSub = System.Drawing.Color.Gray;
            settings2.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings2.ProductNameLitle = "АИС CAD/CAM";
            settings2.SettingsKey = "";
            this.title2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings2, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings2, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title2.ForeColor = System.Drawing.Color.Gray;
            this.title2.Location = new System.Drawing.Point(12, 57);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(115, 26);
            this.title2.TabIndex = 5;
            this.title2.TitleText = "ИМЯ";
            this.title2.TitleTextSub = "";
            // 
            // lnam
            // 
            this.lnam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnam.Location = new System.Drawing.Point(126, 89);
            this.lnam.Name = "lnam";
            this.lnam.Size = new System.Drawing.Size(268, 26);
            this.lnam.TabIndex = 8;
            this.lnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title3
            // 
            this.title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings3.Background = System.Drawing.SystemColors.Control;
            settings3.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings3.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings3.CommentForeSub = System.Drawing.Color.Gray;
            settings3.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings3.ProductNameLitle = "АИС CAD/CAM";
            settings3.SettingsKey = "";
            this.title3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings3, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings3, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title3.ForeColor = System.Drawing.Color.Gray;
            this.title3.Location = new System.Drawing.Point(12, 89);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(115, 26);
            this.title3.TabIndex = 7;
            this.title3.TitleText = "ОТЧЕСТВО";
            this.title3.TitleTextSub = "";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(126, 121);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(268, 26);
            this.login.TabIndex = 10;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title4
            // 
            this.title4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings4.Background = System.Drawing.SystemColors.Control;
            settings4.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings4.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings4.CommentForeSub = System.Drawing.Color.Gray;
            settings4.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings4.ProductNameLitle = "АИС CAD/CAM";
            settings4.SettingsKey = "";
            this.title4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings4, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings4, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title4.ForeColor = System.Drawing.Color.Gray;
            this.title4.Location = new System.Drawing.Point(12, 121);
            this.title4.Name = "title4";
            this.title4.Size = new System.Drawing.Size(115, 26);
            this.title4.TabIndex = 9;
            this.title4.TitleText = "ЛОГИН";
            this.title4.TitleTextSub = "";
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(126, 153);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(268, 26);
            this.pass.TabIndex = 12;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title5
            // 
            this.title5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings5.Background = System.Drawing.SystemColors.Control;
            settings5.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings5.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings5.CommentForeSub = System.Drawing.Color.Gray;
            settings5.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings5.ProductNameLitle = "АИС CAD/CAM";
            settings5.SettingsKey = "";
            this.title5.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings5, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings5, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title5.ForeColor = System.Drawing.Color.Gray;
            this.title5.Location = new System.Drawing.Point(12, 153);
            this.title5.Name = "title5";
            this.title5.Size = new System.Drawing.Size(115, 26);
            this.title5.TabIndex = 11;
            this.title5.TitleText = "ПАРОЛЬ";
            this.title5.TitleTextSub = "";
            // 
            // title6
            // 
            this.title6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings6.Background = System.Drawing.SystemColors.Control;
            settings6.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings6.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings6.CommentForeSub = System.Drawing.Color.Gray;
            settings6.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings6.ProductNameLitle = "АИС CAD/CAM";
            settings6.SettingsKey = "";
            this.title6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings6, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings6, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title6.ForeColor = System.Drawing.Color.Gray;
            this.title6.Location = new System.Drawing.Point(12, 185);
            this.title6.Name = "title6";
            this.title6.Size = new System.Drawing.Size(115, 26);
            this.title6.TabIndex = 13;
            this.title6.TitleText = "ПРАВА";
            this.title6.TitleTextSub = "";
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(126, 185);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(268, 26);
            this.type.TabIndex = 14;
            // 
            // title7
            // 
            this.title7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings7.Background = System.Drawing.SystemColors.Control;
            settings7.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings7.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings7.CommentForeSub = System.Drawing.Color.Gray;
            settings7.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings7.ProductNameLitle = "АИС CAD/CAM";
            settings7.SettingsKey = "";
            this.title7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings7, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings7, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title7.ForeColor = System.Drawing.Color.Gray;
            this.title7.Location = new System.Drawing.Point(12, 217);
            this.title7.Name = "title7";
            this.title7.Size = new System.Drawing.Size(115, 26);
            this.title7.TabIndex = 15;
            this.title7.TitleText = "СОЗДАН";
            this.title7.TitleTextSub = "";
            // 
            // dat
            // 
            this.dat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat.Location = new System.Drawing.Point(126, 217);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(268, 26);
            this.dat.TabIndex = 16;
            // 
            // block
            // 
            this.block.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block.BackColor = System.Drawing.Color.White;
            this.block.Location = new System.Drawing.Point(127, 251);
            this.block.Name = "block";
            this.block.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.block.Size = new System.Drawing.Size(264, 22);
            this.block.TabIndex = 17;
            this.block.UseVisualStyleBackColor = false;
            // 
            // title8
            // 
            this.title8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings8.Background = System.Drawing.SystemColors.Control;
            settings8.CommentBack = System.Drawing.Color.PaleTurquoise;
            settings8.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings8.CommentForeSub = System.Drawing.Color.Gray;
            settings8.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings8.ProductNameLitle = "АИС CAD/CAM";
            settings8.SettingsKey = "";
            this.title8.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings8, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings8, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title8.ForeColor = System.Drawing.Color.Gray;
            this.title8.Location = new System.Drawing.Point(12, 249);
            this.title8.Name = "title8";
            this.title8.Size = new System.Drawing.Size(115, 26);
            this.title8.TabIndex = 18;
            this.title8.TitleText = "БЛОКИРОВАН";
            this.title8.TitleTextSub = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(127, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title8);
            this.Controls.Add(this.block);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.title7);
            this.Controls.Add(this.type);
            this.Controls.Add(this.title6);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.title5);
            this.Controls.Add(this.login);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.lnam);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fam;
        private Views.UControls.Title title1;
        private System.Windows.Forms.TextBox nam;
        private Views.UControls.Title title2;
        private System.Windows.Forms.TextBox lnam;
        private Views.UControls.Title title3;
        private System.Windows.Forms.TextBox login;
        private Views.UControls.Title title4;
        private System.Windows.Forms.TextBox pass;
        private Views.UControls.Title title5;
        private Views.UControls.Title title6;
        private System.Windows.Forms.ComboBox type;
        private Views.UControls.Title title7;
        private System.Windows.Forms.DateTimePicker dat;
        private System.Windows.Forms.CheckBox block;
        private Views.UControls.Title title8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}