using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class RegistrarNotas : ApplicationForm
    {
        public RegistrarNotas()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            cbxCursos.DataSource = new DocenteCursoLogic().GetAllByDocente();
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
    }
}
