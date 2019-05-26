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
using CarWinForm.PresentationEntites;

namespace CarWinForm
{
    public partial class Orders : Form
    {
        private OrderManager _orderManager;
        private readonly int _autoId;
        protected Orders()
        {
            _orderManager = new OrderManager();
            
            InitializeComponent();
            
        }

        public Orders(int autoId) :  this()
        {
            //get orders
            _autoId = autoId;
            var autoOrders = _orderManager.GetOrderByAuto(autoId);
            var orderGridViewList = autoOrders.Select(a => new OrderGridView()
            {
                ComandaID = a.ComandaID,
                Descriere = a.Descriere,
                StareComanda = a.StareComanda,
                DataSystem = a.DAtaSystem,
                DataProgramare = a.DataProgramare,
                KmBord = a.KmBord,
                ValoarePiese = a.ValoarePiese,
                DataFinalizare = a.DataFinalizare
            }).ToList();
            dgvOrders.DataSource = orderGridViewList;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var addAuto = new OrderForm(_autoId);//new AddClientForm(dgvAutoes);
            addAuto.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
