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
            dgvOrders.DataSource = autoOrders;
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
    }
}
