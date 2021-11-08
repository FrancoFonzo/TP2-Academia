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
            try
            {
                MapearInicial();
                ShowForm(true);
                Listar();
            }catch(Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Baja;
                try
                {
                    SaveEntity();
                    ListarInscripciones();
                }
                catch(Exception ex)
                {
                    Notificar(ex.Message);
                }
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                if (this.IsValid)
                {
                    SaveEntity();
                    ShowForm(false);
                    Listar();
                }
            }catch(Exception ex)
            {
                Notificar(ex.Message);
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

        private void MapearEntidad()
        {
            InscripcionActual = InscripcionLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
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
            try
            {
                MapearEntidad();
                InscripcionLogic.Save(InscripcionActual);
                if (Modo == ModoForm.Baja)
                {
                    SelectedID = 0;
                }
            }catch(Exception ex)
            {
                Notificar(ex.Message);
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
            ListarInscripciones();
        }

        private void ListarInscripciones()
        {
            try
            {
                gvInscripciones.DataSource = new AlumnoInscripcionLogic().GetAllAlumno(int.Parse(ddlAlumnos.SelectedValue));
                gvInscripciones.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}