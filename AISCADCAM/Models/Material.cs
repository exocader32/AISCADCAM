using AISCADCAM.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AISCADCAM.Core;

namespace AISCADCAM.Models
{
    public class Material : INotifyPropertyChanged
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }
        public float Price { get; set; }

        [NotMapped] public int Count => Instance.DB.Stocks.FirstOrDefault(s => s.Type == nameof(Material) && s.Name == Name)?.Count ?? -1;
        public Material() { }

        public Material(string name)
        {
            Name = name;
            Price = 1000;
        }

        public Material(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => Name;

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
