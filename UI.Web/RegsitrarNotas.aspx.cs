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
    public partial class RegsitrarNotas : Base
    {

        private Persona PersonaActual { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                formPanelCurso.Visible = true;
                Listar();
            }
        }


        protected void linkCancelar_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void ShowForm(bool visible)
        {
            formPanelCurso.Visible = visible;
            gridPanel.Visible = !visible;
            formPanel.Visible = !visible;
        }

        protected void linkGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (this.IsValid)
            {
                var alumno = (AlumnoInscripcion)gvRegistrarNotas.SelectedValue;
                alumno.Nota = int.Parse(ddlNota.Text);
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
                //ddlCurso.DataSource = new DocenteCursoLogic().GetAllByDocente(PersonaActual.ID);
                this.ddlCurso.DataSource = new CursoLogic().GetAll();
                this.ddlCurso.DataBind();
                var curso = ddlCurso.SelectedValue;
                this.gvRegistrarNotas.DataSource = new AlumnoInscripcionLogic().GetAllByCursos(int.Parse(curso));
                this.gvRegistrarNotas.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de alumnos.");
            }
        }

    }
}
