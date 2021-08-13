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

        public override void Listar()
        {
            try
            {
                this.dgvInscripciones.DataSource = UsuarioActual.MiPersona.MisInscripciones;
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
