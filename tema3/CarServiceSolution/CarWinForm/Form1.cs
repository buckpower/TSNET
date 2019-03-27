using CarServiceManager.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWinForm
{
    public partial class Form1 : Form
    {
        private ClientManager _manager;

        public Form1()
        {
            InitializeComponent();
            _manager = new ClientManager();
            
            dgvClientList.DataSource = _manager.GetClients();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvClientList.Columns.Add(btn);
            btn.HeaderText = "View Client Data";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addClient = new AddClientForm(dgvClientList);
            addClient.Show();
        }

        private void dgvClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }
    }
}
