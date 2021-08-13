using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inscripciones : ApplicationForm
    {
        private Persona PersonaActual { get; }

        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
        }

        public Inscripciones(Persona personaActual) : this()
        {
            PersonaActual = personaActual;
        }

        public Inscripciones(Persona personaActual, bool admin) : this(personaActual)
        {
            if (admin)
            {
                tsbEliminar.Visible = true;
            }
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            InscripcionDesktop formInscripciones = new InscripcionDesktop(PersonaActual, ModoForm.Alta);
            formInscripciones.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvInscripciones))
            {
                OpenForm();
            }
        }

        private void OpenForm()
        {
            int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            InscripcionDesktop formMaterias = new InscripcionDesktop(ID, PersonaActual, ModoForm.Baja);
            formMaterias.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAllAlumno(PersonaActual);
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
