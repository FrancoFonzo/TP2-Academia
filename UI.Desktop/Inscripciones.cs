using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inscripciones : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }

        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
            this.Listar();
        }
        public Inscripciones(Usuario UsuarioActual) : this()
        {
            this.UsuarioActual = UsuarioActual;
        }

        public override void Listar()
        {
            try
            {
                this.dgvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            InscripcionDesktop formInscripciones = new InscripcionDesktop(UsuarioActual, ModoForm.Alta);
            formInscripciones.ShowDialog();
            this.Listar();
        }
    }
}
