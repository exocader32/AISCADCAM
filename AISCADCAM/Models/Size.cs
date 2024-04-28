using AISCADCAM.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    /// <summary> Размер заготовки </summary>
    public class Size : INotifyPropertyChanged
    {
        private string _value;
        [Key] public int Id { get; set; }

        public string Value { get => _value; set { if (value == _value) return; _value = value; OnPropertyChanged(); } }

        public Size() { }
        public Size(string value) => Value = value;
        public override string ToString() => Value;

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
