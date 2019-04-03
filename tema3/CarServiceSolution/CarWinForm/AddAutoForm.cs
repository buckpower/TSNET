using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceManager;
using CarServiceManager.Entities;

namespace CarWinForm
{
    public partial class AddAutoForm : Form
    {
        private int _clientId;
        private AutoManager _manager;
        private DataGridView _parentDataGridView;

        protected AddAutoForm()
        {
            InitializeComponent();
            _manager = new AutoManager();
        }

        public AddAutoForm(int clientId, DataGridView parentDataGridView) : this()
        {
            _clientId = clientId;
            lblClientId.Text = clientId.ToString();
            _parentDataGridView = parentDataGridView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dto = new AutoDTO()
            {
                ClientId = _clientId,
                Sasiu = new SasiuDTO()
                {
                    CodSasiu = tbCodSasiu.Text,
                    Denumire = tbDenumireSasiu.Text
                },
                NumarAuto = tbNumarAuto.Text,
                SerieSasiu = tbSerieSasiu.Text
            };

            _manager.AddAuto(dto);
            _parentDataGridView.DataSource = _manager.GetAutos();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
