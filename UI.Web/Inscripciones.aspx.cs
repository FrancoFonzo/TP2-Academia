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
      
        private static CursoLogic CursoLogic = new CursoLogic();
        private AlumnoInscripcion InscripcionActual { get; set; }
       
       // public Usuario UsuarioActual { get; set; }
        
            
        private Persona PersonaActual { get; set; }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

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
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                MapearInicial();
                ShowForm(true);
                MapearForm(SelectedID);
            }
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
                SaveEntity(SelectedID);
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
            this.ClearForm();
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void ClearForm()
        {
            txtAlumno.Text = string.Empty;

        }

        private void MapearInicial()
        {
            // UsuarioActual = (Usuario)Session["UsuarioGlobal"];

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

            ddlCondicion.DataSource = Enum.GetValues(typeof(AlumnoInscripcion.Condiciones));
            ddlCondicion.DataBind();
            ddlCondicion.Items.Insert(0, "[Seleccionar]");
            gvCursos.DataSource = CursoLogic.GetAllNoInscByPersona(PersonaActual.ID);
            gvCursos.DataBind();
            txtAlumno.Text = PersonaActual.ToString();
        }

        private void MapearForm(int id)
        {
            InscripcionActual = InscripcionLogic.GetOne(id);

            txtAlumno.Text = PersonaActual.ToString();


            ddlCondicion.SelectedValue = InscripcionActual.Condicion.ToString();
            // gvCursos.DataSource = CursoLogic.GetAllNoInscByPersona(PersonaActual.ID);

        }

        private void MapearEntidad()
        {
            InscripcionActual = InscripcionLogic.GetOne(SelectedID);

          // UsuarioActual = (Usuario)Session["UsuarioGlobal"];

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
            InscripcionActual.Alumno = PersonaActual;

            /*if (!String.IsNullOrEmpty(ddlPersona.SelectedValue))
            {
                int.TryParse(ddlPersona.SelectedValue, out int id);
                UsuarioActual.Persona = new PersonaLogic().GetOne(id);
            }*/

            InscripcionActual.Condicion = (AlumnoInscripcion.Condiciones)Enum.Parse(typeof(AlumnoInscripcion.Condiciones), ddlCondicion.SelectedValue);
          //  InscripcionActual.Curso = ;
         //   (Curso)dgvCursos.SelectedRows[0].DataBoundItem;
        }
       
        private void SaveEntity(int id)
        {
            InscripcionActual = InscripcionLogic.GetOne(id);
            MapearEntidad();
            InscripcionLogic.Save(InscripcionActual);
            if (Modo == ModoForm.Baja)
            {
                //Resetear ID seleccionado cuando se borra un registro, ya que el ID dejara de existir.
                SelectedID = 0;
            }
        }
        
        private void Listar()
        {
            try
            {
                
               
              //  PersonaActual = (Persona)Session["UsuarioGlobal"];

                this.gvInscripciones.DataSource = InscripcionLogic.GetAllAlumno(PersonaActual.ID);
                this.gvInscripciones.DataBind();

            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de la inscripcion.");
            }
        }

        protected void gvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                this.SelectedID = (int)this.gvCursos.SelectedValue;
            
        }
    }
}