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
        }

        public InscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public InscripcionDesktop(Persona personaActual, ModoForm modo) : this(modo)
        {
            PersonaActual = personaActual;
            cbxCursos.DataSource = new CursoLogic().GetAll();
            MapearDeDatos();
        }

        public InscripcionDesktop(AlumnoInscripcion inscripcion, ModoForm modo) : this(modo)
        {
            this.InscripcionActual = inscripcion;
            cbxCursos.DataSource = new CursoLogic().GetAll();
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

        public override void MapearDeDatos()
        {
            txtID.Text = PersonaActual.ID.ToString();
            txtUsuario.Text = PersonaActual.Nombre;
            if (InscripcionActual?.MiCurso != null)
            {
                cbxCursos.SelectedValue = InscripcionActual.MiCurso.ID;
            }
            else
            {
                cbxCursos.Text = "Ninguno";
            }
            
            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
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
                InscripcionActual.MiAlumno = PersonaActual;
                InscripcionActual.Condicion = AlumnoInscripcion.Condiciones.Inscripto.ToString();

                var idCur = cbxCursos.SelectedValue;
                InscripcionActual.MiCurso = idCur == null ?
                    null : new CursoLogic().GetOne((int)idCur);
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
                Notificar("Informacion invalida", "Porfavor ingrese un curso valido.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
