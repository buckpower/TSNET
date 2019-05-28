using CarServiceManager.Entities;
using System;
using System.Windows.Forms;
using CarServiceManager.Managers;

namespace CarWinForm
{
    public partial class OperatieForm : Form
    {
        private OperatieManager _manager;
        private DataGridView _parentDataGridView;

        public OperatieForm()
        {
            _manager = new OperatieManager();

            InitializeComponent();
        }
        public OperatieForm(DataGridView dgvparent) : this()
        {
            _parentDataGridView = dgvparent;
        }

        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(tbOpDescription.Text))
            {
                tbOpDescription.Focus();
                errorProvider1.SetError(tbOpDescription, "Please Enter Description");
            }

            if (string.IsNullOrEmpty(tbOpDuration.Text))
            {
                tbOpDuration.Focus();
                errorProvider1.SetError(tbOpDuration, "Please Enter Duration");
            }
            else
            {
                decimal tryparce;
                if (!decimal.TryParse(tbOpDuration.Text, out tryparce))
                {
                    errorProvider1.SetError(tbOpDuration, "Please Enter Decimal Duration");
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckErrors();

            var dto = new OperatieDTO()
            {
               Denumire = tbOpDescription.Text,
               TimpExecutie = decimal.Parse(tbOpDuration.Text)
            };
            _manager.Save(dto);
            _parentDataGridView.DataSource = _manager.GetList();

            this.Close();
        }
    }
}
