using Business.Entities;
using Business.Logic;
using System;
using System.Web.UI;

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
            SelectedID = (int)gvDictados.SelectedValue;
        }


        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            try
            {
                MapearInicial();
                ShowForm(true);
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                try
                {
                    MapearInicial();
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
                catch (Exception ex)
                {
                    Notificar(ex.Message);
                }
            }
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Baja;
                try
                {
                    MapearInicial();
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
                catch (Exception ex)
                {
                    Notificar(ex.Message);
                }
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                if (IsValid)
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
            int.TryParse(ddlDocentes.SelectedValue, out int idDocente);
            DictadoActual.Docente = new PersonaLogic().GetOne(idDocente);
            int.TryParse(ddlCursos.SelectedValue, out int idCurso);
            DictadoActual.Curso = new CursoLogic().GetOne(idCurso);
            DictadoActual.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), ddlCargos.SelectedValue);
        }

        private void SaveEntity(int id)
        {
            try
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
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void Listar()
        {
            try
            {
                gvDictados.DataSource = DocenteCursoLogic.GetAll();
                gvDictados.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}