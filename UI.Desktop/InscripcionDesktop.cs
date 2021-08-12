using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        private Usuario UsuarioActual { get;}
        private AlumnoInscripcion InscripcionActual { get; set; }

        public InscripcionDesktop()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public InscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public InscripcionDesktop(Usuario UsuarioActual, ModoForm modo) : this(modo)
        {
            this.UsuarioActual = UsuarioActual;
            MapearDeDatos();
        }

        public InscripcionDesktop(AlumnoInscripcion inscripcion, ModoForm modo) : this(modo)
        {
            this.InscripcionActual = inscripcion;
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void Listar()
        {
            try
            {
                dgvCursos.DataSource = new CursoLogic().GetCursosSinInscripciones(UsuarioActual.MiPersona.ID);
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de los cursos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearDeDatos()
        {
            txtID.Text = UsuarioActual.ID.ToString();
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            if (InscripcionActual?.MiCurso != null)
            {
                //cbxCursos.SelectedValue = InscripcionActual.MiCurso.ID;
            }
            else
            {
                //cbxCursos.Text = "Ninguno";
            }
            
            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
            else if (Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
            else if (Modo == ModoForm.Alta)
            {
                btnAceptar.Text = "Inscribir";
            }
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
                InscripcionActual.MiCurso = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;
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
            if (!isRowSelected(dgvCursos))
            {
                Notificar("Informacion invalida", "Porfavor seleccione una fila.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
