using System;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Collections.Generic;

namespace UI.Desktop
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        private Persona PersonaActual { get; }
        private AlumnoInscripcion InscripcionActual { get; set; }

        public InscripcionDesktop()
        {
            InitializeComponent();
        }

        public InscripcionDesktop(ModoForm modo) : this()
        {
            try
            {
                Modo = modo;
                MapearInicial();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public InscripcionDesktop(Persona personaActual, ModoForm modo) : this(modo)
        {
            try
            {
                PersonaActual = personaActual;
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public InscripcionDesktop(int ID, Persona personaActual, ModoForm modo) : this(modo)
        {
            try
            {
                InscripcionActual = new AlumnoInscripcionLogic().GetOne(ID);
                PersonaActual = personaActual;
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
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

        private void MapearInicial()
        {
            dgvCursos.AutoGenerateColumns = false;
            cbxCondicion.DataSource = Enum.GetValues(typeof(AlumnoInscripcion.Condiciones));

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Inscribir";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    cbxCondicion.Enabled = true;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            if (Modo != ModoForm.Alta)
            {
                cbxCondicion.Enabled = true;
                cbxCondicion.SelectedItem = InscripcionActual.Condicion;
            }
            txtAlumno.Text = PersonaActual.ToString();
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    InscripcionActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    InscripcionActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    InscripcionActual = new AlumnoInscripcion { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    InscripcionActual.State = BusinessEntity.States.Modified;
                    break;
            }
            InscripcionActual.Alumno = PersonaActual;
            InscripcionActual.Condicion = (AlumnoInscripcion.Condiciones)Enum.Parse(typeof(AlumnoInscripcion.Condiciones), cbxCondicion.SelectedItem.ToString());
            InscripcionActual.Curso = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new AlumnoInscripcionLogic().Save(InscripcionActual);
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
                switch (Modo)
                {
                    case ModoForm.Alta:
                        dgvCursos.DataSource = new CursoLogic().GetAllNoInscByPersona(PersonaActual.ID);
                        break;
                    case ModoForm.Modificacion:
                    case ModoForm.Baja:
                        dgvCursos.DataSource = new List<Curso> { InscripcionActual.Curso };
                        break;
                    case ModoForm.Consulta:
                        break;
                }
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (cbxCondicion.SelectedValue == null)
            {
                Notificar("Informacion invalida", "Porfavor seleccione una condicion valida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsRowSelected(dgvCursos))
            {
                return false;
            }
            var curso = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;
            if (new AlumnoInscripcionLogic().CountInscripcionesByCursos(curso.ID) >= curso.Cupo)
            {
                Notificar("Sin cupos", "El curso no tiene mas cupos disponibles.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
