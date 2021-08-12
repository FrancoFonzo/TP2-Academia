using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inscripciones : ApplicationForm
    {
        private Usuario UsuarioActual { get; }

        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
        }

        public Inscripciones(Usuario usuarioActual) : this()
        {
            UsuarioActual = usuarioActual;
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            InscripcionDesktop formInscripciones = new InscripcionDesktop(UsuarioActual, ModoForm.Alta);
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
    }
}
