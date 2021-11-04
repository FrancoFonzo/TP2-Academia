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
                formPanelCurso.Visible = true;

                /*this.ddlCurso.DataSource = new CursoLogic().GetAll();
                this.ddlCurso.DataBind();*/

                if (UsuarioActual.Persona.Tipo == Persona.TiposPersonas.Administrador)
                {
                    ddlCurso.DataSource = new DocenteCursoLogic().GetAll();
                }
                else
                {
                    ddlCurso.DataSource = new DocenteCursoLogic().GetAllByDocente(UsuarioActual.Persona.ID);
                }

                ddlCurso.DataBind();

                Listar();
            }
        }

        protected void gvRegistrarNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvRegistrarNotas.SelectedValue;
            ShowForm(true);
        }

        protected void ddlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            formPanelCurso.Visible = true;

            Listar();
        }

        protected void linkCancelar_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void ShowForm(bool visible)
        {
            formPanel.Visible = visible;
        }

        protected void linkGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (this.IsValid)
            {
                var alumno = new AlumnoInscripcionLogic().GetOne(this.SelectedID);
                alumno.Nota = int.Parse(ddlNota.SelectedValue);
                alumno.State = BusinessEntity.States.Modified;
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
                new AlumnoInscripcionLogic().Save(alumno);
                ShowForm(false);
                Listar();
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
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de alumnos.");
            }
        }
    }
}
