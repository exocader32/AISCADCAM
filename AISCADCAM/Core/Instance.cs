using System.IO;
using System.Text;
using AISCADCAM.Models;

namespace AISCADCAM.Core
{
    /// <summary> Хранилище оперируемой информации для запущенного экземпляра ПО </summary>
    public static class Instance
    {
        /// <summary> строка подключения к бахе данных MSSQL </summary>
        public static string ConnectionString { get; private set; } = null;

        /// <summary> Контекст базы данных </summary>
        public static AicContent DB { get; set; } = null;

        /// <summary> Текущий авторизованный пользователь </summary>
        internal static User CurrentUser { get; set; } = null;

        internal static bool IsRunning { get; } = false;
        
        static Instance()
        {
            IsRunning = true;
        }

        /// <summary> Инициализация приложения </summary>
        public static void Initialization()
        {
            if (File.Exists("connectionString.txt"))
                ConnectionString = File.ReadAllText("connectionString.txt", Encoding.UTF8);
            else
            {
                ConnectionString = "data source=(localdb)\\mssqllocaldb;initial catalog=AISCADCAMDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                File.WriteAllText("connectionString.txt",ConnectionString, Encoding.UTF8);
            }
            DB = new AicContent(ConnectionString);
        }
    }
}
