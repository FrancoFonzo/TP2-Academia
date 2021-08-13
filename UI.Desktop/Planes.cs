using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Planes : ApplicationForm
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new PlanDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvPlanes))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvPlanes))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvPlanes.DataSource = new PlanLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del plan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
