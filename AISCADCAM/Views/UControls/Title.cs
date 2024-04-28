using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AISCADCAM.Annotations;

namespace AISCADCAM.Views.UControls
{
    /// <summary> комментарий поля </summary>
    public partial class Title : UserControl, INotifyPropertyChanged
    {
        /// <summary> Заголовок главный </summary>
        public string TitleText
        {
            get => label1.Text;
            set
            {
                label1.Text = value;
                OnPropertyChanged();
            }
        }

        /// <summary> Заголовок дополнительный </summary>
        public string TitleTextSub
        {
            get => label2.Text;
            set
            {
                label2.Text = value;
                OnPropertyChanged();
            }
        }

        public Title()
        {
            InitializeComponent();
        }

        #region events

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
