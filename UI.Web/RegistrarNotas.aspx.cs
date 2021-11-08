using Business.Entities;
using Business.Logic;
using System;
using System.Web.UI;

namespace UI.Web
{
    public partial class RegistrarNotas : Base
    {

        private Usuario UsuarioActual { get; set; }

        private AlumnoInscripcion InscripcionActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Docente);
            UsuarioActual = (Usuario)Session["UsuarioGlobal"];
            if (!Page.IsPostBack)
            {
                try
                {
                    formPanelCurso.Visible = true;
                    switch (UsuarioActual.Persona.Tipo)
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
            SelectedID = (int)gvRegistrarNotas.SelectedValue;
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
                    SaveEntity(SelectedID);
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

        private void MapearEntidad()
        {
            InscripcionActual = new AlumnoInscripcionLogic().GetOne(this.SelectedID);

            int.TryParse(txtNota.Text, out int nota);
            if (nota < 0 || nota > 10)
            {
                throw new Exception("La nota debe ser un numero entre 1 y 10");
            }
            InscripcionActual.State = BusinessEntity.States.Modified;
            if (nota == 0)
            {
                InscripcionActual.Nota = null;
            }
            else
            {
                InscripcionActual.Nota = nota;
            }
            
            SetCondicion(InscripcionActual);
        }

        private void SaveEntity(int id)
        {
            try
            {
                InscripcionActual = new AlumnoInscripcionLogic().GetOne(id);
                MapearEntidad();
                new AlumnoInscripcionLogic().Save(InscripcionActual);
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
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
                gvRegistrarNotas.DataSource = new AlumnoInscripcionLogic().GetAllByCurso(idcurso);
                gvRegistrarNotas.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}
