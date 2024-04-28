using AISCADCAM.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    /// <summary> Заказчик </summary>
    public class Client : INotifyPropertyChanged
    {
        private string _fio;

        [Key] public int Id { get; set; }

        public string Fio
        {
            get => _fio;
            set
            {
                if (value == _fio) return;
                _fio = value;
                OnPropertyChanged();
            }
        }

        public Client() { }

        public Client(string fio)
        {
            Fio = fio;
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
