using CarServiceManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceManager.Managers;

namespace CarWinForm
{
    public partial class AddClientForm : Form
    {
        private ClientManager _manager;
        private DataGridView _parentDataGridView;

        public AddClientForm()
        {
            InitializeComponent();
            _manager = new ClientManager();
        }

        public AddClientForm(DataGridView dgvClientList) : this()
        {
            _parentDataGridView = dgvClientList;
        }
        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(tbClientName.Text))
            {
                tbClientName.Focus();
                errorProvider1.SetError(tbClientName, "Please Enter Client Name");
            }

            if (string.IsNullOrEmpty(tbClientSurname.Text))
            {
                tbClientSurname.Focus();
                errorProvider1.SetError(tbClientSurname, "Please Enter Client Surname");
            }

            if (string.IsNullOrEmpty(tbClientAddress.Text))
            {
                tbClientAddress.Focus();
                errorProvider1.SetError(tbClientAddress, "Please Enter Client Address");
            }

            if (string.IsNullOrEmpty(tbClientEmail.Text))
            {
                tbClientEmail.Focus();
                errorProvider1.SetError(tbClientEmail, "Please Enter Client Email");
            }

            if (string.IsNullOrEmpty(tbClientPhone.Text))
            {
                tbClientPhone.Focus();
                errorProvider1.SetError(tbClientPhone, "Please Enter Client Phone");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckErrors();

            var dto = new ClientDTO()
            {
                Nume = tbClientSurname.Text,
                Prenume = tbClientName.Text,
                Adresa = tbClientAddress.Text,
                Localitate = tbClientCity.Text,
                Judet= tbClientCounty.Text,
                Email = tbClientEmail.Text
            };
            _manager.SaveClient(dto);
            _parentDataGridView.DataSource = _manager.GetClients();

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
