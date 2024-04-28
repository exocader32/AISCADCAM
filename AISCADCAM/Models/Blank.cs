using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AISCADCAM.Annotations;
using System.Runtime.CompilerServices;

namespace AISCADCAM.Models
{
    /// <summary> Заготовка на складе </summary>
    public class Blank : INotifyPropertyChanged
    {
        [Key] public int Id { get; set; }

        private Material _material;
        private Block _block;
        private Model _model;
        private Color _color;
        private Size _size;


        /// <summary> материал </summary>
        public virtual Material Material { get => _material; set { if (Equals(value, _material)) return; _material = value; OnPropertyChanged(); } }

        /// <summary> Блок </summary>
        public Block Block { get => _block; set { if (Equals(value, _block)) return; _block = value; OnPropertyChanged(); } }

        /// <summary> Модель </summary>
        public virtual Model Model { get => _model; set { if (Equals(value, _model)) return; _model = value; OnPropertyChanged(); } }

        /// <summary> цвет (из цветовой раскладкИ) </summary>
        public virtual Color Color { get => _color; set { if (value == _color) return; _color = value; OnPropertyChanged(); } }

        /// <summary> размер материала </summary>
        public virtual Size Size { get => _size; set { if (Equals(value, _size)) return; _size = value; OnPropertyChanged(); } }
        
        public Blank(){ }
        
        public Blank(Material material, Block block, Model model, Color color, Size size)
        {
            Material = material;
            Block = block;
            Model = model;
            Color = color;
            Size = size;
        }

        public override string ToString() => $"{Material}/{Block}/{Model}/{Size}/{Color}";

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
