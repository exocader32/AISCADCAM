using AISCADCAM.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AISCADCAM.Core;

namespace AISCADCAM.Models
{
    /// <summary> Блок </summary>
    public class Block : INotifyPropertyChanged
    {
        private string _name;

        [Key] public int Id { get; set; }

        /// <summary> Наименование </summary>
        public string Name { get => _name; set { if (value == _name) return; _name = value; OnPropertyChanged(); } }

        [NotMapped] public int Count => Instance.DB.Stocks.FirstOrDefault(s=>s.Type==nameof(Block)&&s.Name==Name)?.Count??-1;

        public Block() { }

        public Block(string name)=>Name = name;

        public override string ToString() => Name;

        #region event action

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
