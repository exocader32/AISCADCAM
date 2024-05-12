using System;
using System.Linq;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Properties;
using MaterialSkin.Controls;

namespace AISCADCAM
{
    // форма авторизации
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            // заголовок окна
            Text = Settings.Default.ProductName;
            // обнулить данные авторизованного пользователя
            Instance.CurrentUser = null;
// в режиме отладки входить в выбранную учетную запись автоматически (для быстрого запуска)
#if DEBUG
            // указать от какого пользователя выполнить вход (указать Type)
            //Instance.CurrentUser = Instance.DB.Users.FirstOrDefault(u => u.Type == EUser.Бухгалтер);
            //Close();
#endif
        }

        // по Enter - нажать Вход
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
                button1_Click(sender, e);
        }

        //los3inkgitnux80kgit!Uu

        // вход
        private void button1_Click(object sender, EventArgs e)
        {
            
            // ищем пользователя
            Instance.CurrentUser = Instance.DB.Users.FirstOrDefault(u => u.Login == textBox1.Text);
            // если не найден - ждем новых данных
            if( Instance.CurrentUser == null ) return;
            // если пароля нет
            if (string.IsNullOrEmpty(Instance.CurrentUser?.Password))
            {
                // предлагаем пользователю сменить пароль на новый
                Hide();
                new FormChangePassword(Instance.CurrentUser) { Owner=this }.ShowDialog();
                Show();
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            if (Instance.CurrentUser.Password.Decrypt() != textBox2.Text)
            {
                MessageBox.Show("Указанный пароль неверен!", "В доступе отказано");
                Instance.CurrentUser = null;
                return;
            }
            // уведомление
            if (Instance.CurrentUser?.IsBlock??false)
            {
                MessageBox.Show("Пользователь Заблокирован!", "Ошибка входа");
                textBox2.Text = null;
                return;
            }
            Close();
        }
    }
}
