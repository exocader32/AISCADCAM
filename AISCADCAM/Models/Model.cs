using AISCADCAM.Annotations;
using AISCADCAM.Core;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    public class Model : INotifyPropertyChanged
    {
        private string _name;

        [Key] public int Id { get; set; }

        /// <summary> Наименование </summary>
        public string Name { get => _name; set { if (value == _name) return; _name = value; OnPropertyChanged(); } }

        [NotMapped] public int Count => Instance.DB.Stocks.FirstOrDefault(s => s.Type == nameof(Model) && s.Name == Name)?.Count ?? -1;

        public Model() { }

        public Model(string name) => Name = name;
       
        public override string ToString() => Name;

        #region event action

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
