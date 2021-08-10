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
        public AlumnoInscripcionDesktop(Usuario UsuarioActual) : this()
        {
            this.UsuarioActual = UsuarioActual;
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
                MiCurso = new CursoLogic().GetOne((int)this.cbxCursos.SelectedValue)
            };
            
            var idCur = this.cbxCursos.SelectedValue;
            this.CursoActual = new CursoLogic().GetOne((int)idCur);
            
        }

        public void ListarInscripciones()
        {

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

        private void btnListarInscripciones_Click(object sender, EventArgs e)
        {
            ListarInscripciones();
        }
    }
}
