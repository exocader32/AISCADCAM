using System;
using System.Net.Security;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Views.Forms;

namespace AISCADCAM
{
    internal static class Program
    {
        /// <summary> Главная точка входа для приложения. </summary>
        [STAThread] static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Instance.Initialization();
            do
            {
                // авуторзиация
                Application.Run(new FormAuthorization());
                // если пользователь авторизовался
                if(Instance.CurrentUser!=null)
                // открываем соответсвущее типу учетной записи представление
                switch (Instance.CurrentUser.Type)
                {
                    case EUser.Администратор: Application.Run(new FormAdministrator()); break;
                    case EUser.Завсклада: Application.Run(new FormStorekeeper()); break;
                    case EUser.Специалист: Application.Run(new FormSpecialist()); break;
                    case EUser.Бухгалтер: Application.Run(new FormBuhgalter()); break;
                    case EUser.Сотрудник: Application.Run(new FormSotrudnik()); break;
                }
            } while (Instance.CurrentUser != null);
        }
    }
}
