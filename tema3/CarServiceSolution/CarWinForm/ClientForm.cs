using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarServiceManager;
using CarServiceManager.Entities;
using CarServiceManager.Managers;
using CarWinForm.PresentationEntites;

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
            var autoList = _autoManager.GetAutosByClientId(clientId).Select(s =>new AutoGridView()
            {
                AutoId = s.AutoId,
                NumarAuto = s.NumarAuto,
                SerieSasiu =  s.SerieSasiu,
                CodSasiu = s.Sasiu.CodSasiu,
                DenumireSasiu = s.Sasiu.Denumire
            }).ToList();
            dgvAutoes.DataSource = autoList;
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
            lblClientID.Text = "" + dto.Id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addAuto = new AddAutoForm(int.Parse(lblClientID.Text), dgvAutoes);//new AddClientForm(dgvAutoes);
            addAuto.Show();
        }
    }
}
