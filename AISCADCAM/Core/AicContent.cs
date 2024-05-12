using System;
using System.IO;
using System.Linq;
using AISCADCAM.Models;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AISCADCAM.Core
{
    /// <summary> Контекст данных БД </summary>
    public class AicContent : DbContext
    {
        /// <summary> Сотрудники клиники </summary>
        public DbSet<User> Users { get; set; }
  
        /// <summary> Заказчики клиники </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary> В наличии на складе </summary>
        public DbSet<Stock> Stocks { get; set; }
       
        /// <summary> Материалы </summary>
        public DbSet<Material> Materials { get; set; }
       
        /// <summary> Размер </summary>
        public DbSet<Size> Sizes { get; set; }

        /// <summary> Цвета </summary>
        public DbSet<Color> Colors { get; set; }

        /// <summary> Блок </summary>
        public DbSet<Block> Blocks { get; set; }

        /// <summary> Модель </summary>
        public DbSet<Model> Models { get; set; }

        /// <summary> Заготовки на складе </summary>
        public DbSet<Blank> Blanks { get; set; }

        /// <summary> Пациенты </summary>
        public DbSet<Patient> Patients { get; set; }

        /// <summary> Заказ-наряды </summary>
        public DbSet<Order> Orders { get; set; }



        public AicContent() : base(Instance.ConnectionString) => Initialization();

        public AicContent(string connectionString) : base(connectionString) => Initialization();

        //заполнение БД тестовыми данными
        private void Initialization()
        {
            try
            {
                //заполнение БД тестовыми данными
                if (!Users.Any())
                {
                    Users.AddRange(new[]
                    {
                        new User("Администратор","базы","данных",EUser.Администратор,"admin","root".Encrypt()),
                        new User("Иванов","Иван","Иванович",     EUser.Бухгалтер, "b","b".Encrypt()),
                        new User("Пертов","Игорь","Сергеевич",   EUser.Завсклада, "z","z".Encrypt()),
                        new User("Велиев","Виталий","Юрьевич",   EUser.Специалист,"s","s".Encrypt()),
                        new User("Велиев","Виталий","Юрьевич",   EUser.Сотрудник,"c","c".Encrypt()),
                    });
                    SaveChanges();
                }

                if (!Clients.Any())
                {
                    Clients.AddRange(new[]
                    {
                        new Client("Иванов"),
                        new Client("Кутепов"),
                        new Client("Дипломат"),
                        new Client("Павленко"),
                        new Client("Карнаухов"),
                    });
                    SaveChanges();
                }
                if (!Sizes.Any())
                {
                    Sizes.AddRange(new[]
                    {
                        new Size("10"),
                        new Size("12"),
                        new Size("14"),
                        new Size("16"),
                        new Size("18"),
                        new Size("20"),
                        new Size("22"),
                        new Size("24"),
                        new Size("25"),
                    });
                    SaveChanges();
                }
                if (!Patients.Any())
                {
                    Patients.AddRange(new[]
                    {
                        new Patient("Иванищенко Елена Викторовна","0340958349085345"),
                        new Patient("Сидоренко Семён Сергеевич",  "0234560485340598"),
                        new Patient("Свириденко Артём Семёнович", "0129879068765765"),
                        new Patient("Буран Филиан Тагирович",     "0126677899765960"),
                    });
                    SaveChanges();
                }
                if (!Blocks.Any())
                {
                    Blocks.AddRange(new[]
                    {
                        new Block("CeraDirect"),
                        new Block("OMNITEC"),
                        new Block("Vladmiva"),
                        new Block("Xantech"),
                        new Block("Ziceram"),
                        new Block("Zotion"),
                    });
                    SaveChanges();
                }
                if (!Models.Any())
                {
                    Models.AddRange(new[]
                    {
                        new Model("ATM"),
                        new Model("STM"),
                        new Model("HT"),
                        new Model("SSC"),
                        new Model("HT"),
                        new Model("SSC"),
                        new Model("HTC"),
                        new Model("ML"),
                        new Model("CT"),
                        new Model("ET"),
                        new Model("STC"),
                        new Model("ML_3D_PRO"),
                        new Model("ML_4D_PRO"),
                        new Model("ML_5D_PRO"),
                    });
                    SaveChanges();
                }
                if (!Materials.Any())
                {
                    Materials.AddRange(new[]
                    {
                        new Material("PMMA",400),
                        new Material("Zr02",1200),
                        new Material("Wax",100),
                        new Material("смола",0),
                        new Material("Elego PMMA",100),
                    });
                    SaveChanges();
                }
                if (!Colors.Any())
                {
                    Colors.AddRange(new[]
                    {
                        new Color("A1"),
                        new Color("A2"),
                        new Color("A3"),
                        new Color("A3.5"),
                        new Color("A4"),
                        new Color("B1"),
                        new Color("B2"),
                        new Color("B3"),
                        new Color("B4"),
                        new Color("C1"),
                        new Color("C2"),
                        new Color("C3"),
                        new Color("C4"),
                        new Color("D2"),
                        new Color("D3"),
                        new Color("D4"),
                        new Color("BL"),
                    });
                    SaveChanges();
                }
                if (!Stocks.Any())
                {
                    foreach (Material m in Materials.ToList())
                        Stocks.Add(new Stock(m.Name) { Type = m.GetType().Name, Count = 1000 });
                    foreach (Block m in Blocks.ToList())
                        Stocks.Add(new Stock(m.Name) { Type = m.GetType().Name, Count = 1000 });
                    foreach (Model m in Models.ToList())
                        Stocks.Add(new Stock(m.Name) { Type = m.GetType().Name, Count = 1000 });
                    SaveChanges();
                }
                if (!Orders.Any())
                {
                    var mat = Materials.ToList();
                    var pat = Patients.ToList();
                    var usr = Clients.ToList();
                    var c = Colors.ToList();
                    var bl = Blocks.ToList();
                    var mod = Models.ToList();
                    var s = Sizes.ToList();

                    var rnd = new Random();
                    for(var dt=DateTime.Parse("01.02.24");dt<DateTime.Now;dt=dt.AddDays(1))
                    {
                        int count = rnd.Next(0, 4);
                        for(int i=0;i<count;i++)
                        {
                            var o = new Order
                            {
                                Create = dt, Patient = pat[i],
                                Blank = new Blank(mat[rnd.Next(mat.Count)], bl[rnd.Next(bl.Count)],
                                    mod[rnd.Next(mod.Count)], c[rnd.Next(c.Count)], s[rnd.Next(s.Count)]),
                                Tooths = "35,36,37,38",
                                Stabilizator = false, FreeRevision = false,
                                Client = usr[0], Payment = 0f, Discount = 0f, Price = 4800f,
                            };
                            o.Price = o.ResultPrice();
                            Orders.Add(o);
                        }
                    }
                    SaveChanges();
                }
            }
            catch (Exception e)
            {
                // пересоздать бд
                Database.Delete();
                Initialization();
            }
        }

        /// <summary> Создать бакап </summary>
        public void Backup()
        {
            string path = $"{Application.StartupPath}\\backup\\";
            Directory.CreateDirectory(path);
            string dbname = Database.Connection.Database;
            string sqlCommand = $"BACKUP DATABASE [{dbname}] " +
                                $"TO DISK=N'{path}back_{DateTime.Now:ddMMyyyyhhmmss}.bak' " +
                                $"WITH NOFORMAT, NOINIT,  NAME = N'{dbname}-Full Database Backup', " +
                                $"SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);
            MessageBox.Show("BACKUP COMPLITE");
        }

        /// <summary> восстановить из бакапа </summary>
        /// <param name="path"> полный путь к файлу .bak </param>
        public void Restore(string path)
        {
            string dbname = Database.Connection.Database;
            Database.Connection.Close();
            using (var conn = new SqlConnection(Instance.ConnectionString))
            {
                conn.Open();
                var script = $"USE [master]; ALTER DATABASE [{dbname}] " +
                             $"SET Single_User WITH Rollback Immediate;";
                var cmd = new SqlCommand(script, conn);
                cmd.ExecuteNonQuery();
                script = $"RESTORE DATABASE [{dbname}] FROM DISK=N'{path}' " +
                         $"WITH RESTRICTED_USER, FILE = 1, NOUNLOAD, REPLACE, STATS = 10;";
                cmd = new SqlCommand(script, conn);
                cmd.ExecuteNonQuery();
                script = $@"ALTER DATABASE [{dbname}] SET Multi_User;";
                cmd = new SqlCommand(script, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Database.Connection.Open();
            Users.Load();
            MessageBox.Show("RESTOPE COMPLITE");
        }
    }
}
