using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Personas : ApplicationForm
    {
        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbAgregarP_Click(object sender, EventArgs e)
        {
            PersonaDesktop formPersona = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void tsbEditarP_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvPersonas))
            {
                openForm(ApplicationForm.ModoForm.Modificacion);
            }
        }

        private void tsbEliminarP_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvPersonas))
            {
                openForm(ApplicationForm.ModoForm.Baja);
            }
        }

        private void openForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            var formPersona = new PersonaDesktop(ID, modo);
            formPersona.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvPersonas.DataSource = new PersonaLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
