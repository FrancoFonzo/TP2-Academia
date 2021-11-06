using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class RegistrarNotas : Base
    {

        private Usuario UsuarioActual { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioActual = (Usuario)Session["UsuarioGlobal"];
            
            if (!Page.IsPostBack)
            {
                try
                {
                    formPanelCurso.Visible = true;
                    switch (UsuarioActual.Persona?.Tipo)
                    {
                        case Persona.TiposPersonas.Administrador:
                            lblDocente.Visible = true;
                            ddlDocente.Visible = true;
                            ddlDocente.DataSource = new PersonaLogic().GetAllTipo(Persona.TiposPersonas.Docente);
                            ddlDocente.DataBind();
                            break;
                        case Persona.TiposPersonas.Docente:
                            ddlCurso.DataSource = new DocenteCursoLogic().GetAllByDocente(UsuarioActual.Persona.ID);
                            ddlCurso.DataBind();
                            Listar();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Notificar(ex.Message);
                }   
            }
        }

        protected void gvRegistrarNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvRegistrarNotas.SelectedValue;
            ShowForm(true);
        }

        protected void ddlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                formPanelCurso.Visible = true;
                Listar();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
        protected void ddlDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ddlCurso.DataSource = new DocenteCursoLogic().GetAllByDocente(int.Parse(ddlDocente.SelectedValue));
                ddlCurso.DataBind();
                Listar();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                if (this.IsValid)
                {
                    var alumno = new AlumnoInscripcionLogic().GetOne(this.SelectedID);

                    int.TryParse(txtNota.Text, out int nota);
                    if (nota < 1 || nota > 10)
                    {
                        throw new Exception("La nota debe ser un numero entre 1 y 10");
                    }
                    alumno.State = BusinessEntity.States.Modified;
                    SetCondicion(alumno);
                    new AlumnoInscripcionLogic().Save(alumno);
                    ShowForm(false);
                    Listar();
                }
            }
            catch (Exception ex)
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

        private static void SetCondicion(AlumnoInscripcion alumno)
        {
            if (alumno.Nota >= 6)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
            }
            else if (alumno.Nota >= 4)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Regular;
            }
            else
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Inscripto;
            }
        }

        private void Listar()
        {
            try
            {
                int idcurso = int.Parse(ddlCurso.SelectedValue);
                this.gvRegistrarNotas.DataSource = new AlumnoInscripcionLogic().GetAllByCursos(idcurso);
                this.gvRegistrarNotas.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}
