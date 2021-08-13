using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        private Persona PersonaActual { get;}
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

        public InscripcionDesktop(Persona personaActual, ModoForm modo) : this(modo)
        {
            PersonaActual = personaActual;
            MapearDeDatos();
        }

        public InscripcionDesktop(int ID, Persona personaActual, ModoForm modo) : this(personaActual, modo)
        {
            InscripcionActual = new AlumnoInscripcionLogic().GetOne(ID);
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

        public override void MapearDeDatos()
        {
            txtID.Text = PersonaActual.ID.ToString();
            txtUsuario.Text = PersonaActual.Nombre;

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
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
                InscripcionActual = new AlumnoInscripcion
                {
                    State = BusinessEntity.States.New,
                    MiAlumno = PersonaActual,
                    Condicion = AlumnoInscripcion.Condiciones.Inscripto.ToString(),
                    MiCurso = (Curso)dgvCursos.SelectedRows[0].DataBoundItem
                };
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

        public override void Listar()
        {
            try
            {
                if (Modo == ModoForm.Alta)
                {
                    dgvCursos.DataSource = new CursoLogic().GetCursosNoInscripto(PersonaActual.ID);
                }
                else
                {
                    dgvCursos.DataSource = InscripcionActual?.MiCurso;
                }                    
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de los cursos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!isRowSelected(dgvCursos))
            {
                Notificar("Accion invalida", "Porfavor seleccione una fila.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
