namespace AISCADCAM.Views.Models
{
    partial class EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClient));
            this.title10 = new AISCADCAM.Views.UControls.Title();
            this.text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title10
            // 
            this.title10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settings1.Background = System.Drawing.SystemColors.Control;
            settings1.CommentBack = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            settings1.CommentFore = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings1.CommentForeSub = System.Drawing.Color.Gray;
            settings1.ProductName = "Автоматизированная система учёта CAD/CAM зуботехнической лаборатории";
            settings1.ProductNameLitle = "АИС CAD/CAM";
            settings1.SettingsKey = "";
            this.title10.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "CommentBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title10.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "CommentForeSub", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title10.ForeColor = System.Drawing.Color.Gray;
            this.title10.Location = new System.Drawing.Point(12, 12);
            this.title10.Name = "title10";
            this.title10.Size = new System.Drawing.Size(144, 26);
            this.title10.TabIndex = 39;
            this.title10.TitleText = "НАИМЕНОВАНИЕ";
            this.title10.TitleTextSub = "";
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(155, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(343, 26);
            this.text.TabIndex = 40;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(181, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title10);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ЗАКАЗЧИК";
            this.Load += new System.EventHandler(this.EditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControls.Title title10;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button button1;
    }
}