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
                tsbEditar.Visible = true;
            }
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                new InscripcionDesktop(PersonaActual, ModoForm.Alta).ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvInscripciones))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvInscripciones))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            try
            {
                int ID = ((AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                new InscripcionDesktop(ID, PersonaActual, modo).ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Listar()
        {
            try
            {
                dgvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAllAlumno(PersonaActual.ID);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
