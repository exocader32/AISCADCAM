using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using AISCADCAM.Annotations;
using AISCADCAM.Core;

namespace AISCADCAM.Models
{
    /// <summary> Пользователь </summary>
    public class User : INotifyPropertyChanged
    {
        private string _famile;
        private string _name;
        private string _lastName;
        private string _login;
        private string _password;
        private bool _isBlock;
        private EUser _type;
        private DateTime _date;

        [Key] public int Id { get; set; }

        /// <summary> Фамилия </summary>
        public string Famile {
            get => _famile;
            set
            {
                if (value == _famile) return;
                _famile = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Fio));
                OnPropertyChanged(nameof(FioSmall));
            }
        }

        /// <summary> Имя </summary>
        public string Name {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Fio));
                OnPropertyChanged(nameof(FioSmall));
            }
        }

        /// <summary> Отчество </summary>
        public string LastName {
            get => _lastName;
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Fio));
                OnPropertyChanged(nameof(FioSmall));
            }
        }

        /// <summary> Тип учётной записи </summary>
        public EUser Type {
            get => _type;
            set
            {
                if (value == _type) return;
                _type = value;
                OnPropertyChanged();
            }
        }

        /// <summary> Логин </summary>
        public string Login {
            get => _login;
            set
            {
                if (value == _login) return;
                _login = value;
                OnPropertyChanged();
            }
        }

        /// <summary> Пароль </summary>
        public string Password {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value; 
                OnPropertyChanged();
            }
        }

        /// <summary> Признак блокировки пользователя </summary>
        public bool IsBlock {
            get => _isBlock;
            set
            {
                if (value == _isBlock) return;
                _isBlock = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Equals(_date)) return;
                _date = value;
                OnPropertyChanged();
            }
        }

        /// <summary> Польное имя </summary>
        [NotMapped] public string Fio => $"{Famile} {Name} {LastName}";

        /// <summary> Фамилия + инициалы </summary>
        [NotMapped] public string FioSmall => $"{Famile}{(Name!=null?$" {Name.First()}.":"")}{(LastName!=null?$"{LastName.First()}.":"")}";
    
        public User(){ }
        public User(string famile, string name, string lastName, EUser type, string login, string password, bool isBlock=false)
        {
            Famile = famile;
            Name = name;
            LastName = lastName;
            Type = type;
            Login = login;
            Password = password;
            IsBlock = isBlock;
            Date = DateTime.Now;
        }

        public override string ToString() => Fio;

        #region event action

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
