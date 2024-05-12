using System;
using System.Data.Entity.Migrations;
using AISCADCAM.Models;
using System.Windows.Forms;
using AISCADCAM.Core;

namespace AISCADCAM
{
    /// <summary> форма правки пользователей </summary>
    public partial class EditUser : Form
    {
        public static User Result { get; private set; } = null;
        private User _user = null;
        public EditUser(User user)
        {
            Result = null;
            InitializeComponent();
            if (user == null) user = new User{Date = DateTime.Now};
            if(user.Date<=dat.MinDate) user.Date = dat.MinDate.AddDays(100);
            _user = user;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // заполнение данных
            Text = $@"{(_user.Id == 0 ? "СОЗДАНИЕ" : "ИЗМЕНЕНИЕ")} ПОЛЬЗОВАТЕЛЯ";
            button1.Text = (_user.Id == 0 ? "СОЗДАТЬ" : "ИЗМЕНИТЬ");
            fam.Text = _user.Famile;
            nam.Text = _user.Name;
            lnam.Text = _user.LastName;
            login.Text = _user.Login;
            pass.Text = _user.Password.Decrypt();
            dat.Value = _user.Date;
            block.Checked = _user.IsBlock;
            type.Items.AddRange(Enum.GetNames(typeof(EUser)));
            type.SelectedItem = _user.Type.ToString();
            // обработка изменений в данных
            fam.TextChanged += (o, args) => _user.Famile = fam.Text;
            nam.TextChanged += (o, args) => _user.Name = nam.Text;
            lnam.TextChanged += (o, args) => _user.LastName = lnam.Text;
            login.TextChanged += (o, args) => _user.Login = login.Text;
            pass.TextChanged += (o, args) => _user.Password = pass.Text.Encrypt();
            dat.ValueChanged += (o, args) => _user.Date = dat.Value;
            block.CheckedChanged += (o, args) => _user.IsBlock = block.Checked;
            type.SelectedIndexChanged += (o, args) =>
                _user.Type = (EUser)Enum.Parse(typeof(EUser), type.SelectedItem.ToString());
        }

        // ок
        private void button1_Click(object sender, EventArgs e)
        {
            // сохранить данные
            Result = _user;
            // созранить в бд
            if (_user.Id == 0) Instance.DB.Users.Add(_user);
            else Instance.DB.Users.AddOrUpdate(_user);
            Instance.DB.SaveChanges();
            // закрыть форму
            Close();
        }
    }
}
