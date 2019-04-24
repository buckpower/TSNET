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

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvAutoes.Columns.Add(btn);
            btn.HeaderText = "View Car Orders";
            btn.Text = "Orders";
            btn.Name = "btnOrders";
            btn.UseColumnTextForButtonValue = true;
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

        private void dgvAutoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                var autoDTOList = dgvAutoes.DataSource as List<AutoGridView>;

                if (autoDTOList != null && autoDTOList.Count > 0)
                {
                    var autoDTOId = autoDTOList[e.RowIndex].AutoId;
                    var orderForm = new Orders(autoDTOId);
                    orderForm.Show();
                }
            }
        }
    }
}
