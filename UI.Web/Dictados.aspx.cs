using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Dictados : Base
    {
        private static DocenteCursoLogic DocenteCursoLogic = new DocenteCursoLogic();
        private DocenteCurso DictadoActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Administrador);
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void gvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvDictados.SelectedValue;
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

            ddlDocentes.DataSource = new PersonaLogic().GetAllTipo(Persona.TiposPersonas.Docente);
            ddlDocentes.DataBind();
            ddlDocentes.Items.Insert(0, "[Seleccionar]");

            ddlCursos.DataSource = new CursoLogic().GetAll();
            ddlCursos.DataBind();
            ddlCursos.Items.Insert(0, "[Seleccionar]");

            ddlCargos.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
            ddlCargos.DataBind();
            ddlCargos.Items.Insert(0, "[Seleccionar]");
        }

        private void MapearForm(int id)
        {
            DictadoActual = DocenteCursoLogic.GetOne(id);

            ddlDocentes.SelectedValue = DictadoActual.Docente.ID.ToString();
            ddlCursos.SelectedValue = DictadoActual.Curso.ID.ToString();
            ddlCargos.SelectedValue = DictadoActual.Cargo.ToString();
        }

        private void MapearEntidad()
        {
            DictadoActual = DocenteCursoLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    DictadoActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    DictadoActual = new DocenteCurso { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    DictadoActual.State = BusinessEntity.States.Modified;
                    break;
            }
            DictadoActual.Docente = new PersonaLogic().GetOne(int.Parse(ddlDocentes.SelectedValue));
            DictadoActual.Curso = new CursoLogic().GetOne(int.Parse(ddlCursos.SelectedValue));
            DictadoActual.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), ddlCargos.SelectedValue);
        }

        private void SaveEntity(int id)
        {
            DictadoActual = DocenteCursoLogic.GetOne(id);
            MapearEntidad();
            DocenteCursoLogic.Save(DictadoActual);
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
                this.gvDictados.DataSource = DocenteCursoLogic.GetAll();
                this.gvDictados.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de los cursos.");
            }
        }
    }
}