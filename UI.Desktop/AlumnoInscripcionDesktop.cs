using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {
        private Usuario UsuarioActual { get; set; }
        private AlumnoInscripcion InscripcionActual { get; set; }
        private Curso CursoActual { get; set; }

        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }
        public AlumnoInscripcionDesktop(int ID) : this()
        {
            this.UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            List<Curso> cursos = new CursoLogic().GetAll();
            cursos.Add(this.CursoActual);
            this.cbxCursos.DataSource = cursos;

            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
        }

        public override void MapearADatos()
        {
            this.cbxCursos.DataSource = new CursoLogic().GetAll();

            this.InscripcionActual = new AlumnoInscripcion
            {
                MiAlumno = this.UsuarioActual.MiPersona,
                Condicion = AlumnoInscripcion.Condiciones.Inscripto.ToString(),
                MiCurso = this.cbxCursos.SelectedValue
        };
            
            var idCur = this.cbxCursos.SelectedValue;
            this.CursoActual = new CursoLogic().GetOne((int)idCur);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new AlumnoInscripcionLogic().Save(InscripcionActual);
        }
    }
}
