using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceManager.Entities;
using CarServiceManager.Managers;

namespace CarWinForm
{
    public partial class MaterialForm : Form
    {
        private MaterialsManager _manager;
        private DataGridView _parentDataGridView;

        public MaterialForm(DataGridView parentDataGridView):this()
        {
            _parentDataGridView = parentDataGridView;
        }

        public MaterialForm()
        {
            _manager = new MaterialsManager();
            InitializeComponent();
        }

        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(tbMatQuantity.Text))
            {
                tbMatQuantity.Focus();
                errorProvider1.SetError(tbMatQuantity, "Please Enter Quantity");
            }
            else
            {
                decimal tryparce;
                if (!decimal.TryParse(tbMatQuantity.Text, out tryparce))
                {
                    errorProvider1.SetError(tbMatQuantity, "Please Enter Decimal");
                }
            }

            if (string.IsNullOrEmpty(tbMatPrice.Text))
            {
                tbMatPrice.Focus();
                errorProvider1.SetError(tbMatPrice, "Please Enter Name");
            }
            else
            {
                decimal tryparce;
                if (!decimal.TryParse(tbMatPrice.Text, out tryparce))
                {
                    errorProvider1.SetError(tbMatPrice, "Please Enter Decimal");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckErrors();
            /*
             * Denumire – string[50]
                Cantitate – decimal 10.2
                Pret – decimal 10.2
                DataAprovizionare – data calendaristica
             */

            var dto = new MaterialDTO()
            {
                Denumire = tbMatName.Text,
                Cantitate = decimal.Parse(tbMatQuantity.Text),
                Pret = decimal.Parse(tbMatPrice.Text),
                DataAprovizionare = DateTime.Now
            };

            _manager.Save(dto);
            _parentDataGridView.DataSource = _manager.GetList();

            this.Close();
        }
    }
}
