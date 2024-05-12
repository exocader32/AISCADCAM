using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Models;
using AISCADCAM.Properties;
using MaterialSkin.Controls;

namespace AISCADCAM
{
    /// <summary> форма смена пароля </summary>
    public partial class FormChangePassword : MaterialForm
    {
        private User _user = null;
        public FormChangePassword(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            Text = Settings.Default.ProductName;
            user.Text = _user.Fio;
            pass1.Focus();
            if (_user?.Password != "")
            {
                MessageBox.Show("Нельзя сбросить пароль, пока администратор системы не разрешит этого...");
                Close();
            }
        }

        private void Naxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (sender is Button btn)
                    btn.GetNextControl(btn,true)?.Focus();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
                button1_Click(sender, e);
        }

        // сменить пароль
        private void button1_Click(object sender, EventArgs e)
        {
            // проверки 
            if (pass1.Text != pass2.Text || string.IsNullOrWhiteSpace(pass1.Text))
            {
                MessageBox.Show("Пароли не совпадают. Укажите одинаковые пароли");
                return;
            }

            if (pass1.Text.Length < 2)
            {
                MessageBox.Show("Пароль не соответствует условиям политикам безопасности! Укажите более сложный пароль ...");
                pass1.Text = pass2.Text = null;
                pass1.Focus();
                return;
            }

            _user.Password = pass1.Text.Encrypt();
            // обновить данные 
            Instance.DB.Users.AddOrUpdate(_user);
            // сохранить изменения
            Instance.DB.SaveChanges();
            // задать текущего пользователя с новыми данными
            var tmp = pass1.Text.Encrypt();
            Instance.CurrentUser =
                Instance.DB.Users.FirstOrDefault(u => u.Login == _user.Login && u.Password== tmp);
            if (Instance.CurrentUser == null)
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка входа");
                pass1.Text = null;
                return;
            }
            Close();
        }

        private void FormChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Instance.CurrentUser = null;
        }
    }
}
