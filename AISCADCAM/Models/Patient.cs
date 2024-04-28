using AISCADCAM.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    public class Patient : INotifyPropertyChanged
    {
        [Key] public int Id { get; set; }
        private string _fio;
        private string _snilsNumber;

        /// <summary> ФИО пациента </summary>
        public string Fio {
            get => _fio;
            set
            {
                if (value == _fio) return;
                _fio = value;
                OnPropertyChanged();
            }
        }

        /// <summary> СНИЛС пациента </summary>
        public string SnilsNumber {
            get => _snilsNumber;
            set
            {
                if (value == _snilsNumber) return;
                _snilsNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary> Персональная скидка </summary>
        public float PersonalDiscont { get; set; }

        public Patient(){ }

        public Patient(string fio, string snilsNumber)
        {
            Fio = fio;
            SnilsNumber = snilsNumber;
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
