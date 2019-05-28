using CarServiceManager.Entities;
using CarServiceManager.Managers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarWinForm
{
    public partial class Form1 : Form
    {
        private ClientManager _clientManager;
        private OperatieManager _operatieManager;
        private MaterialsManager _materialManager;
        private MecanicsManager _mecanicManager;

        public Form1()
        {
            InitializeComponent();
            _clientManager = new ClientManager();

            InitControls();
            AddListButton(dgvClientList,"btnViewClient","View");
            AddListButton(dgvCatalog, "btnViewOp", "View");
            AddListButton(dgvInventoryList, "btnViewMaterial", "View");
            AddListButton(dgvStaffList, "btnViewMechanic", "View");
        }

        private void InitControls()
        {
            //Client
            _clientManager = new ClientManager();
            dgvClientList.DataSource = _clientManager.GetList();

            //Catalog
            _operatieManager = new OperatieManager();
            dgvCatalog.DataSource = _operatieManager.GetList();

            //Inventory
            _materialManager = new MaterialsManager();
            dgvInventoryList.DataSource = _materialManager.GetList();

            //Staff
            _mecanicManager = new MecanicsManager();
            dgvStaffList.DataSource = _mecanicManager.GetList();
        }

        private void AddListButton(DataGridView dgv, string btnName, string btnText)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv.Columns.Add(btn);
            btn.HeaderText = "View Client Data";
            btn.Name = btnName;
            btn.Text = btnText;

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

        private T GetEntityByRowIndex<T>(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            var list = dgv.DataSource as List<T>;
            var id = list[e.RowIndex];

            return id;
        }

        private void dgvClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                //var clientList = dgvClientList.DataSource as List<ClientDTO>;
                //var clientId = clientList[e.RowIndex].Id;

                var clientId = GetEntityByRowIndex<ClientDTO>(dgvClientList, e);
                var clientForm = new ClientForm(clientId.Id);
                clientForm.Show();
            }
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                //var clientList = dgvClientList.DataSource as List<ClientDTO>;
                //var clientId = clientList[e.RowIndex].Id;

                var opId = GetEntityByRowIndex<OperatieDTO>(dgvCatalog, e);
                //var opForm = new OperatieForm(opId.OperatieId);
                var opForm = new OperatieForm();
                opForm.Show();
            }
        }

        private void dgvInventoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                //var clientList = dgvClientList.DataSource as List<ClientDTO>;
                //var clientId = clientList[e.RowIndex].Id;

                var materialId = GetEntityByRowIndex<MaterialDTO>(dgvInventoryList, e);
                //var opForm = new MaterialForm(materialId);
                var opForm = new MaterialForm();

                opForm.Show();
            }
        }

        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                //var clientList = dgvClientList.DataSource as List<ClientDTO>;
                //var clientId = clientList[e.RowIndex].Id;

                var mecanicId = GetEntityByRowIndex<MecanicDTO>(dgvStaffList, e);
                //var mecanicForm = new MechanicForm(mecanicId);

                var mecanicForm = new MechanicForm();
                mecanicForm.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.InitControls();
        }
        private void brnRefreshCatalog_Click(object sender, EventArgs e)
        {
            this.InitControls();

        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            this.InitControls();

        }

        private void btnRefreshStaff_Click(object sender, EventArgs e)
        {
            this.InitControls();

        }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            var addOp = new OperatieForm(dgvCatalog);
            addOp.Show();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            var addOp = new MaterialForm(dgvInventoryList);
            addOp.Show();
        }

        private void btnAddMecanic_Click(object sender, EventArgs e)
        {
            var addOp = new MechanicForm(dgvStaffList);
            addOp.Show();
        }
    }
}
