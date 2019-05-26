using CarServiceManager.Entities;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using CarServiceManager.Managers;
using CarServiceManager;

namespace CarWinForm
{
    public partial class OrderForm : Form
    {
        private OrderManager _orderManager;
        private AutoManager _autoManager;

        private readonly int _autoId;
        private readonly AutoDTO _autoDto;

        public OrderForm()
        {
            InitManagers();
            InitializeComponent();
            cbxOrderStatus.DataSource = Enum.GetValues(typeof(StareComandaDto));
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.CustomFormat = "yyyy.MM.dd HH:mm";
        }

        public OrderForm(int autoId) : this()
        {
            _autoDto = _autoManager.GetAuto(autoId);
            var client = _autoDto.Client;

            lblClientName.Text = client.Nume + " " + client.Prenume;
            lblAutoNr.Text = _autoDto.NumarAuto;
            dtpAppointmentDate.Value = DateTime.Now;

            cbxOrderStatus.SelectedIndex = 0;
            cbxOrderStatus.Enabled = false;
        }

        private void InitManagers()
        {
            _orderManager = new OrderManager();
            _autoManager = new AutoManager();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //create order
            /*
             * AddNewOrder(AutoDTO auto, StareComandaDto sc, string description, DateTime appDateTime,
            int dashKm, IList<ImagineDTO> imgs)
             */
            StareComandaDto stareComanda;
            Enum.TryParse<StareComandaDto>(cbxOrderStatus.SelectedText.ToString(), out stareComanda);

            var description = rtbxDescription.Text;
            var appointmentDate = dtpAppointmentDate.Value;
            var dashKm = Int32.Parse(tbxKm.Text);

            _orderManager.AddNewOrder(_autoDto, stareComanda,description,appointmentDate,dashKm, null);

            this.Close();
        }
    }
}
