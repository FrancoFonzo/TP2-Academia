using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        private Usuario UsuarioActual { get; set; }
        private AlumnoInscripcion InscripcionActual { get; set; }

        public InscripcionDesktop()
        {
            InitializeComponent();
        }

        public InscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public InscripcionDesktop(Usuario UsuarioActual, ModoForm modo) : this(modo)
        {
            this.UsuarioActual = UsuarioActual;
            cbxCursos.DataSource = new CursoLogic().GetAll();
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = UsuarioActual.ID.ToString();
            txtUsuario.Text = UsuarioActual.NombreUsuario;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                InscripcionActual = new AlumnoInscripcion { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    InscripcionActual.State = BusinessEntity.States.Modified;
                }
                InscripcionActual.MiAlumno = UsuarioActual.MiPersona;
                InscripcionActual.Condicion = AlumnoInscripcion.Condiciones.Inscripto.ToString();
                InscripcionActual.MiCurso = new CursoLogic().GetOne((int)cbxCursos.SelectedValue);
            }
            else if (Modo == ModoForm.Baja)
            {
                InscripcionActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                InscripcionActual.State = BusinessEntity.States.Unmodified;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new AlumnoInscripcionLogic().Save(InscripcionActual);
        }

        public override bool Validar()
        {
            if (cbxCursos.SelectedValue == null)
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
