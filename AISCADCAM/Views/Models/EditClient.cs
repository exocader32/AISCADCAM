using System;
using AISCADCAM.Models;
using System.Windows.Forms;

namespace AISCADCAM.Views.Models
{
    public partial class EditClient : Form
    {
        public static Client Result = null;
        private Client _client = null;
        public EditClient(Client client)
        {
            Result = null;
            _client = client;
            InitializeComponent();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            text.Text = _client.Fio;
            text.TextChanged += (s, args) => _client.Fio = text.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = _client;
            Close();
        }
    }
}
