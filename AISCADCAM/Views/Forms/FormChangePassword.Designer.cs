namespace AISCADCAM
{
    partial class FormChangePassword
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AISCADCAM.Properties.Resources.tqLyNfR;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Depth = 0;
            this.user.Hint = "ПОЛЬЗОВАТЕЛЬ";
            this.user.Location = new System.Drawing.Point(136, 88);
            this.user.MouseState = MaterialSkin.MouseState.HOVER;
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.SelectedText = "";
            this.user.SelectionLength = 0;
            this.user.SelectionStart = 0;
            this.user.Size = new System.Drawing.Size(285, 23);
            this.user.TabIndex = 7;
            this.user.UseSystemPasswordChar = false;
            // 
            // pass1
            // 
            this.pass1.Depth = 0;
            this.pass1.Hint = "ПАРОЛЬ";
            this.pass1.Location = new System.Drawing.Point(136, 117);
            this.pass1.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '\0';
            this.pass1.SelectedText = "";
            this.pass1.SelectionLength = 0;
            this.pass1.SelectionStart = 0;
            this.pass1.Size = new System.Drawing.Size(285, 23);
            this.pass1.TabIndex = 8;
            this.pass1.UseSystemPasswordChar = true;
            // 
            // pass2
            // 
            this.pass2.Depth = 0;
            this.pass2.Hint = "ПОВТОР ПАРОЛЯ";
            this.pass2.Location = new System.Drawing.Point(136, 146);
            this.pass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '\0';
            this.pass2.SelectedText = "";
            this.pass2.SelectionLength = 0;
            this.pass2.SelectionStart = 0;
            this.pass2.Size = new System.Drawing.Size(285, 23);
            this.pass2.TabIndex = 9;
            this.pass2.UseSystemPasswordChar = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(285, 202);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(136, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "СМЕНИТЬ ПАРОЛЬ";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 266);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СМЕНА ПАРОЛЯ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField user;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass1;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

