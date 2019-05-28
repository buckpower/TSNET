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
using CarServiceManager.Entities;

namespace CarWinForm
{
    public partial class MechanicForm : Form
    {
        private MecanicsManager _manager;
        private DataGridView _parentDataGridView;

        public MechanicForm(DataGridView parentDataGridView) : this()
        {
            _parentDataGridView = parentDataGridView;
        }

        public MechanicForm()
        {
            _manager = new MecanicsManager();
            InitializeComponent();
        }

        private void CheckErrors()
        {
            if (string.IsNullOrEmpty(tbMecName.Text))
            {
                tbMecName.Focus();
                errorProvider1.SetError(tbMecName, "Please Enter Name");
            }

            if (string.IsNullOrEmpty(tbMecSurname.Text))
            {
                tbMecSurname.Focus();
                errorProvider1.SetError(tbMecSurname, "Please Enter SurName");
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

            var dto = new MecanicDTO()
            {
                Nume= tbMecName.Text,
                Prenume = tbMecSurname.Text
            };

            _manager.Save(dto);
            _parentDataGridView.DataSource = _manager.GetList();

            this.Close();
        }
    }
}
