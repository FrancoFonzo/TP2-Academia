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
    public partial class Cursos : Base
    {
        private static CursoLogic CursoLogic = new CursoLogic();
        private Curso CursoActual { get; set; }

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
            this.SelectedID = (int)this.gvCursos.SelectedValue;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            try
            {
                MapearInicial();
                ShowForm(true);
            }catch(Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                try { 
                    MapearInicial();
                    ShowForm(true);
                    MapearForm(SelectedID);
                }catch(Exception ex)
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
                this.Validate();
                if (this.IsValid)
                {
                    SaveEntity(SelectedID);
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
            this.ClearForm();
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void ClearForm()
        {
            txtAnio.Text = string.Empty;
            txtCupo.Text = string.Empty;
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

            try { 
                ddlComision.DataSource = new ComisionLogic().GetAll();
                ddlComision.DataBind();
                ddlComision.Items.Insert(0, "[Seleccionar]");

                ddlMateria.DataSource = new MateriaLogic().GetAll();
                ddlMateria.DataBind();
                ddlMateria.Items.Insert(0, "[Seleccionar]");
            }catch(Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void MapearForm(int id)
        {
            try
            {
                CursoActual = CursoLogic.GetOne(id);

                txtAnio.Text = CursoActual.AnioCalendario.ToString();
                txtCupo.Text = CursoActual.Cupo.ToString();
                ddlComision.SelectedValue = CursoActual.Comision.ID.ToString();
                ddlMateria.SelectedValue = CursoActual.Materia.ID.ToString();
            }catch(Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void MapearEntidad()
        {
            try
            {
                CursoActual = CursoLogic.GetOne(SelectedID);
                switch (Modo)
                {
                    case ModoForm.Baja:
                        SelectedID.ToString();
                        CursoActual.State = BusinessEntity.States.Deleted;
                        return;
                    case ModoForm.Alta:
                        CursoActual = new Curso { State = BusinessEntity.States.New };
                        break;
                    case ModoForm.Modificacion:
                        CursoActual.State = BusinessEntity.States.Modified;
                        break;
                }

                if (int.Parse(txtAnio.Text) > 0 && int.Parse(txtCupo.Text) > 0)
                {
                    CursoActual.AnioCalendario = int.Parse(txtAnio.Text);
                    CursoActual.Cupo = int.Parse(txtCupo.Text);
                    CursoActual.Comision = new ComisionLogic().GetOne(int.Parse(ddlComision.SelectedValue));
                    CursoActual.Materia = new MateriaLogic().GetOne(int.Parse(ddlMateria.SelectedValue));
                }
                else
                {
                    Notificar("Año y cupo deben ser positivos");
                }
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void SaveEntity(int id)
        {
            try
            {
                CursoActual = CursoLogic.GetOne(id);
                MapearEntidad();
                CursoLogic.Save(CursoActual);
                if (Modo == ModoForm.Baja)
                {
                    //Resetear ID seleccionado cuando se borra un registro, ya que el ID dejara de existir.
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
                this.gvCursos.DataSource = CursoLogic.GetAll();
                this.gvCursos.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de los cursos.");
            }
        }
    }
}