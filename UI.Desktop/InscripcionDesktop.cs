using System;
using System.Collections.Generic;
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
            this.cbxCursos.DataSource = new CursoLogic().GetAll();
            MapearDeDatos();
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

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.InscripcionActual = new AlumnoInscripcion { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.InscripcionActual.State = BusinessEntity.States.Modified;
                }
                this.InscripcionActual.MiAlumno = this.UsuarioActual.MiPersona;
                this.InscripcionActual.Condicion = AlumnoInscripcion.Condiciones.Inscripto.ToString();
                this.InscripcionActual.MiCurso = new CursoLogic().GetOne((int)this.cbxCursos.SelectedValue);
            }
            else if (Modo == ModoForm.Baja) InscripcionActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) InscripcionActual.State = BusinessEntity.States.Unmodified;      
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new AlumnoInscripcionLogic().Save(InscripcionActual);
        }
    }
}
