using System;
using System.Linq;
using AISCADCAM.Core;
using AISCADCAM.Models;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AISCADCAM
{
    //
    public partial class SelectingBlank : Form
    {
        public static Blank Result = null;
    
        public SelectingBlank(Blank b=null)
        {
            Result = null;
            InitializeComponent();
        }

        private void SelectingBlank_Load(object sender, EventArgs e)
        {
            materials.Items.Add("");
            sizes.Items.Add("");
            colors.Items.Add("");
            materials.Items.AddRange(Instance.DB.Materials.ToArray());
            sizes.Items.AddRange(Instance.DB.Sizes.ToArray());
            colors.Items.AddRange(Instance.DB.Colors.ToArray());
            SortBlanks(sender,e);
        }

        private void SortBlanks(object sender, EventArgs e)
        {
            List<Blank> data = Instance.DB.Blanks.ToList();
            if (materials.SelectedItem is Material m)
                data = data.Where(d => d.Material?.Id == m.Id).ToList();
            if(sizes.SelectedItem is Size s)
                data = data.Where(d => d.Size?.Id == s.Id).ToList();
            if(colors.SelectedItem is Color c)
                data = data.Where(d => d.Color?.Id == c.Id).ToList();
            listBox1.DataSource = null;
            listBox1.DataSource = data;
        }

        private void Ok(object sender, EventArgs e)
        {
            var b = (Blank)listBox1.SelectedItem;
            if(b==null) return;
            Result = b;
            Instance.DB.SaveChanges();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
