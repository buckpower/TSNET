using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarServiceManager;
using CarServiceManager.Entities;
using CarServiceManager.Managers;

namespace CarWinForm
{
    public partial class ClientForm : Form
    {
        private ClientManager _clientManager;
        private AutoManager _autoManager;
        protected ClientForm()
        {
            InitializeComponent();
            _clientManager = new ClientManager();
            _autoManager = new AutoManager();
        }

        public ClientForm(int clientId) : this()
        {
            //Get client info
            var client = _clientManager.GetClientById(clientId);
            //Get client auto
            var autoList = _autoManager.GetAutosByClientId(clientId);

            //fill presentation
            FillClientInfo(client);
        }

        public void AutoDataGrid(List<AutoDTO> autos)
        {
            dgvAutoes.DataSource = autos;
        }

        private void FillClientInfo(ClientDTO dto)
        {
            lblClientName.Text = dto.Prenume;
            lblClientSurname.Text = dto.Nume;
            lblClientAddress.Text = dto.Adresa;
            lblClientCity.Text = dto.Localitate;
            lblClientCounty.Text = dto.Judet;
            lblClientTelephone.Text = "" + dto.Telefon;
            lblClientEmail.Text = dto.Email;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addAuto = new AddClientForm(dgvAutoes);
            addAuto.Show();
        }
    }
}
