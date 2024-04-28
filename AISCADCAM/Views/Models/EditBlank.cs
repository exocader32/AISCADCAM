using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using AISCADCAM.Core;
using AISCADCAM.Models;

namespace AISCADCAM
{
    /// <summary> редактирование бланка </summary>
    public partial class EditBlank : Form
    {
        public static Blank Result = null;

        private Blank _blank = null;
        public EditBlank(Blank blank)
        {
            if (blank == null) blank = new Blank();
            Result = blank;
            _blank = blank;
            InitializeComponent();
            Text = $"{(_blank.Id == 0 ? "СОЗДАНИЕ" : "ИЗМЕНЕНИЕ")} БЛАНКА";
            ok.Text = (_blank.Id == 0 ? "СОЗДАТЬ" : "ИЗМЕНИТЬ");
        }

        // открытие формы
        private void EditBlank_Load(object sender, EventArgs e)
        {
            // заполнить данные
            mat.Items.Add("");   mat.Items.AddRange(Instance.DB.Materials.ToArray());
            block.Items.Add(""); block.Items.AddRange(Instance.DB.Blocks.ToArray());
            model.Items.Add(""); model.Items.AddRange(Instance.DB.Models.ToArray());
            color.Items.Add(""); color.Items.AddRange(Instance.DB.Colors.ToArray());
            size.Items.Add(""); size.Items.AddRange(Instance.DB.Sizes.ToArray());
            // указать текущие выбранные данные
            mat.SelectedItem = _blank.Material;
            block.SelectedItem = _blank.Block;
            model.SelectedItem = _blank.Model;
            color.SelectedItem = _blank.Color;
            size.SelectedItem = _blank.Size; 
            // обработать изменения данных пользователем
            mat.SelectedIndexChanged += (o, args) => {
                if (mat.SelectedIndex > 0) _blank.Material = (Material)mat.SelectedItem;
            };
            block.SelectedIndexChanged += (o, args) => {
                if (block.SelectedIndex > 0) _blank.Block = (Block)block.SelectedItem;
            };
            model.SelectedIndexChanged += (o, args) => {
                if(model.SelectedIndex>0) _blank.Model = (Model)model.SelectedItem;
            };
            color.SelectedIndexChanged += (o, args) => {
                if(color.SelectedIndex>0) _blank.Color = (Color)color.SelectedItem;
            };
            size.SelectedIndexChanged += (o, args) => {
                if (size.SelectedIndex > 0) _blank.Size = (Size)size.SelectedItem;
            };
        }

        // ок
        private void ok_Click(object sender, EventArgs e)
        {
            // если бланк новый - добавим его в бд
            if(_blank.Id==0) _blank = Instance.DB.Blanks.Add(_blank);
            // иначе обновим данные в бд
            else Instance.DB.Blanks.AddOrUpdate(_blank);
            // сохраним в результататах бланк
            Result = _blank;
            // закрыть форму
            Close();
        }
    }
}
