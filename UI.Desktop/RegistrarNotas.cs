using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class RegistrarNotas : ApplicationForm
    {
        private Persona PersonaActual { get; }

        public RegistrarNotas()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
        }

        public RegistrarNotas(Persona personaActual) : this()
        {
            PersonaActual = personaActual;
            cbxCursos.DataSource = new DocenteCursoLogic().GetAllByDocente(PersonaActual.ID);
        }
        
        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public override void Listar()
        {
            try
            {
                var idCurso = cbxCursos.SelectedValue;
                if(idCurso != null)
                {
                    dgvAlumnos.DataSource = new AlumnoInscripcionLogic().GetAllByCursos((int)idCurso);
                }
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var alumno = (AlumnoInscripcion)dgvAlumnos.SelectedRows[0].DataBoundItem;
            alumno.Nota = int.Parse(txtNota.Text);
            alumno.State = BusinessEntity.States.Modified;
            if(alumno.Nota >= 6)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
            }else if(alumno.Nota >= 4)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Regular;
            }
            else
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Inscripto;
            }
            new AlumnoInscripcionLogic().Save(alumno);
        }
    }
}
