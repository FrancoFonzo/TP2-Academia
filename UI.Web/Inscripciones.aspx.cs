using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Inscripciones : Base
    {
        private static AlumnoInscripcionLogic InscripcionLogic = new AlumnoInscripcionLogic();
        private AlumnoInscripcion InscripcionActual { get; set; }        
            
        private Usuario UsuarioActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioActual = (Usuario)Session["UsuarioGlobal"];

            if (!Page.IsPostBack)
            {
                if(UsuarioActual.Persona.Tipo == Persona.TiposPersonas.Alumno)
                {
                    gvInscripciones.Columns.RemoveAt(4);
                    linkEliminar.Visible = false;
                    lblAlumnos.Visible = false;
                    ddlAlumnos.Visible = false;
                }
                ddlAlumnos.DataSource = new PersonaLogic().GetAllTipo(Persona.TiposPersonas.Alumno);
                ddlAlumnos.DataBind();

                Listar();
            }
        }
        protected void gvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvInscripciones.SelectedValue;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            MapearInicial();
            ShowForm(true);
            Listar();
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Baja;
                MapearInicial();
                ShowForm(true);
                MapearForm(SelectedID);
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (this.IsValid)
            {
                SaveEntity();
                ShowForm(false);
                Listar();
            }
        }

        protected void linkCancelar_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void ShowForm(bool visible)
        {
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void MapearInicial()
        {

            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    linkAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    linkAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    linkAceptar.Text = "Aceptar";
                    break;
            }
            gvCursos.DataSource = new CursoLogic().GetAllNoInscByPersona(UsuarioActual.Persona.ID);
            gvCursos.DataBind();
        }

        private void MapearForm(int id)
        {
            InscripcionActual = InscripcionLogic.GetOne(id);
        }

        private void MapearEntidad()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    InscripcionActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    InscripcionActual = new AlumnoInscripcion { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    InscripcionActual.State = BusinessEntity.States.Modified;
                    break;
            }

            if(UsuarioActual.Persona.Tipo == Persona.TiposPersonas.Administrador)
            {
                InscripcionActual.Alumno = new PersonaLogic().GetOne(int.Parse(ddlAlumnos.SelectedValue));
            }
            else
            {
                InscripcionActual.Alumno = UsuarioActual.Persona;
            }

            InscripcionActual.Curso = new CursoLogic().GetOne(this.cursoSelectedID);
        }
       
        private void SaveEntity()
        {
            MapearEntidad();
            InscripcionLogic.Save(InscripcionActual);
            if (Modo == ModoForm.Baja)
            {
                SelectedID = 0;
            }
        }
        
        private void Listar()
        {
            try
            {
                gvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAllAlumno(UsuarioActual.Persona.ID);
                gvInscripciones.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void gvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cursoSelectedID = (int)this.gvCursos.SelectedValue;
        }

        protected void ddlAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAllAlumno(int.Parse(ddlAlumnos.SelectedValue));
            gvInscripciones.DataBind();
        }
    }
}