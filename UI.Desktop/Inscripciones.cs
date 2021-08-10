using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inscripciones : ApplicationForm
    {
        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
        }
        public Inscripciones(Usuario UsuarioActual) : this()
        {
            this.UsuarioActual = UsuarioActual;
        }

        public Usuario UsuarioActual{get; set;}

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
            AlumnoInscripcionDesktop formInscripciones = new AlumnoInscripcionDesktop(UsuarioActual);
            formInscripciones.ShowDialog();
            this.Listar();
        }
    }
}
