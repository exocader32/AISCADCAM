using AISCADCAM.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    public class Color : INotifyPropertyChanged
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public Color() { }

        public Color(string name)
        {
            Name = name;
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
