using AISCADCAM.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    /// <summary> Содкржимое склада </summary>
    public class Stock : INotifyPropertyChanged
    {
        private string _name;
        private string _type;
        private int _count;

        [Key] public int Id { get; set; }

        /// <summary> Тип материала </summary>
        public string Type { get => _type; set { if (value == _type) return; _type = value; OnPropertyChanged(); } }

        /// <summary> Наименование </summary>
        public string Name { get => _name; set { if (value == _name) return; _name = value; OnPropertyChanged(); } }

        /// <summary> Остаток на складе </summary>
        public int Count { get => _count; set { if (value == _count) return; _count = value; OnPropertyChanged(); } }


        public Stock() { }

        public Stock(string name) => Name = name;

        public override string ToString() => $"{Name} ({Count})";

        #region event action

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
