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
            Text = tipo.ToString();
            tsbAgregar.Visible = false;
            tsbEditar.Visible = false;
            tsbEliminar.Visible = false;
            tsbSeleccionar.Visible = true;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbAgregarP_Click(object sender, EventArgs e)
        {
            PersonaDesktop formPersona = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            formPersona.ShowDialog();
            Listar();
        }

        private void tsbEditarP_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvPersonas))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminarP_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvPersonas))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvPersonas))
            {
                if(TipoPersona == Persona.TiposPersonas.Alumno)
                {
                    openFormInscripcion();
                }
                else
                {
                    openFormRegistrarNotas();
                }
                
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((Persona)dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            new PersonaDesktop(ID, modo).ShowDialog();
            Listar();
        }

        private void openFormInscripcion()
        {
            Persona persona = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
            Program.MainUI.OpenForm(new Inscripciones(persona, true));
        }

        private void openFormRegistrarNotas()
        {
            Persona persona = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
            Program.MainUI.OpenForm(new RegistrarNotas(persona));
        }

        public override void Listar()
        {
            try
            {
                dgvPersonas.DataSource = TipoPersona == Persona.TiposPersonas.Administrador ?
                    new PersonaLogic().GetAll() : new PersonaLogic().GetAllTipo(TipoPersona);
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
