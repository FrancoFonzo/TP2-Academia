using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Personas : ApplicationForm
    {
        public Persona.TiposPersonas TipoPersona { get; } = Persona.TiposPersonas.Administrador;

        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        public Personas(Persona.TiposPersonas tipo) : this()
        {
            TipoPersona = tipo;
            tsbAgregar.Visible = false;
            tsbEditar.Visible = false;
            tsbEliminar.Visible = false;
            tsbSeleccionar.Visible = true;
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

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvPersonas))
            {
                openFormInscripcion();
            }
        }

        private void openForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            var formPersona = new PersonaDesktop(ID, modo);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void openFormInscripcion()
        {
            Persona persona = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
            var form = new Inscripciones(persona, true);
            Program.MainUI.openForm(form);
        }

        public override void Listar()
        {
            try
            {
                dgvPersonas.DataSource = TipoPersona == Persona.TiposPersonas.Administrador ?
                    new PersonaLogic().GetAll() : new PersonaLogic().GetAllTipos(TipoPersona);
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
