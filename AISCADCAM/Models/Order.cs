using System;
using System.Linq;
using AISCADCAM.Annotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISCADCAM.Models
{
    /// <summary> Заказ-наряд </summary>
    public class Order : INotifyPropertyChanged
    {
        #region private

        private DateTime _create;
        private Patient _patient;
        private Blank _blank;
        private string _tooths;
        private bool _stabilizator;
        private Client _user;
        private float _price;
        private float _discount;
        private float _payment;
        private bool _freeRevision;
        private string _commentary;
        private bool _isPayment;

        #endregion

        #region public

        [Key] public int Id { get; set; }

        /// <summary> дата поступления </summary>
        public DateTime Create { get => _create; set { if (value.Equals(_create)) return; _create = value; OPC(); } }

        /// <summary> Заказчик (сотрудник клиники) </summary>
        public virtual Client Client { get => _user; set { if (Equals(value, _user)) return; _user = value; OPC(); } }

        /// <summary> пациент </summary>
        public virtual Patient Patient { get => _patient; set { if (Equals(value, _patient)) return; _patient = value; OPC(); } }

        /// <summary> Заготовка </summary>
        public virtual Blank Blank { get => _blank; set { if (Equals(value, _blank)) return; _blank = value; OPC(); } }
    
        /// <summary> Номер зуба </summary>
        public string Tooths { get => _tooths; set { if (Equals(value, _tooths)) return; _tooths = value; OPC(); OPC(nameof(ToothCount)); } }
        
        /// <summary> Кол-во зубов </summary>
        [NotMapped] public int ToothCount { get => Tooths?.Split(',')?.Length??0; }
        
        /// <summary> Стабилизатор для синтеризации </summary>
        public bool Stabilizator { get => _stabilizator; set { if (value == _stabilizator) return; _stabilizator = value; OPC(); } }

        /// <summary> Стоимость </summary>
        public float Price { get => _price; set { if (value.Equals(_price)) return; _price = value; OPC(); } }

        /// <summary> Скидка </summary>
        public float Discount { get => _discount; set { if (value.Equals(_discount)) return; _discount = value; OPC(); } }

        /// <summary> Оплачено клиентом </summary>
        public float Payment { get => _payment; set { if (value.Equals(_payment)) return; _payment = value; OPC(); } }

        /// <summary> Признак оплаты клиентом </summary>
        public bool IsPayment { get => _isPayment; set { if (value == _isPayment) return; _isPayment = value; OPC(); } }

        /// <summary> Бесплатная доработка </summary>
        public bool FreeRevision { get => _freeRevision; set { if (value == _freeRevision) return; _freeRevision = value; OPC(); } }

        /// <summary> размер материала </summary>
        public string Commentary { get => _commentary; set { if (value == _commentary) return; _commentary = value; OPC(); } }

        [NotMapped] public string Status
        {
            get { return IsPayment ? "Готов" : "В работе"; }
        }

        #endregion

        public Order() { }

        public OrderGrid ToGrid()
        {
            return new OrderGrid
            {
                Id=Id,
                Create = Create.ToString("dd-MM-yyyy"),
                Patient = Patient?.Fio??"", 
                ToothNumbers = $"[{Tooths}]" , 
                Stabilizator = Stabilizator?"Да":"Нет", 
                User = Client?.Fio??"", 
                Price = Price==0f?"":Price.ToString("C"),
                Discount = Discount == 0f?"": Discount.ToString("C"), 
                Payment = Payment == 0f?"": Payment.ToString("C"),
                FreeRevision = FreeRevision?"Да":"Нет",
                ToPayment= ResultPrice().ToString("C"),
                IsPayment = IsPayment,
                Material = Blank?.Material?.Name,
                Model = Blank?.Model?.Name,
                Block = Blank?.Block?.Name,
                Color = Blank?.Color?.Name,
                Size = Blank?.Size?.Value,
                Status = Status,
                Blank = Blank?.Material?.Name,
                Commentary = this.Commentary
            };
        }

        public float ResultPrice()
        {
            return 
                (FreeRevision ? 0f : 1f) * 
                (
                    Price + ToothCount*(Blank?.Material?.Price??0+(Stabilizator?300:0)) -
                    Discount - (Patient?.PersonalDiscont ?? 0)
                );
        }
 
        #region event action

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OPC([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    public class OrderGrid
    {
        public int Id { get; set; }
        /// <summary> дата поступления </summary>
        public string Create { get; set; }
        /// <summary> пациент </summary>
        public string Patient { get; set; }
        /// <summary> Номера зубов </summary>
        public string ToothNumbers { get; set; }
        /// <summary> Стабилизатор для синтеризации </summary>
        public string Stabilizator { get; set; }
        /// <summary> Материал </summary>
        public string Material { get; set; }
        /// <summary> Модель </summary>
        public string Model { get; set; }
        /// <summary> Блок </summary>
        public string Block { get; set; }
        /// <summary> Блок </summary>
        public string Blank { get; set; }
        /// <summary> Цвет </summary>
        public string Color { get; set; }
        /// <summary> Высота блока </summary>
        public string Size { get; set; }
        /// <summary> Заказчик (сотрудник клиники) </summary>
        public string User { get; set; }
        /// <summary> Стоимость </summary>
        public string Price { get; set; }
        /// <summary> Скидка </summary>
        public string Discount { get; set; }
        /// <summary> Оплачено клиентом </summary>
        public string Payment { get; set; }
        /// <summary> К оплате </summary>
        public string ToPayment { get; set; }
        /// <summary> Бесплатная доработка </summary>
        public string FreeRevision { get; set; }
        /// <summary> Признак оплаты клиентом </summary>
        public bool IsPayment { get; set; }
        public string Status { get; set; }
        public string Commentary { get; set; }
    }
}
