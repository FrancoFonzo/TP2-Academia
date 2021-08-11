using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Comisiones : ApplicationForm
    {
        public Comisiones()
        {
            InitializeComponent();
            dgvComisiones.AutoGenerateColumns = false;
        }
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            ComisionDesktop formComision = new ComisionDesktop(ModoForm.Alta);
            formComision.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvComisiones))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvComisiones))
            {
                OpenForm(ModoForm.Baja);
            }
        }
        private void OpenForm(ModoForm modo)
        {
            int ID = ((Comision)dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop formComision = new ComisionDesktop(ID, modo);
            formComision.ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvComisiones.DataSource = new ComisionLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de las comisiones",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
