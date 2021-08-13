using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Especialidades : ApplicationForm
    {
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new EspecialidadDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvEspecialidades))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvEspecialidades))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            new EspecialidadDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvEspecialidades.DataSource = new EspecialidadLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
