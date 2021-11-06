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
    public partial class Materias : Base
    {
        private static MateriaLogic MateriaLogic = new MateriaLogic();

        private Materia MateriaActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void gvMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvMaterias.SelectedValue;
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

        private void ShowForm(bool visible)
        {
            this.ClearForm();
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void ClearForm()
        {
            txtMateria.Text = string.Empty;
            txtHorasTotales.Text = string.Empty;
            txtHorasSemanales.Text = string.Empty;
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

            ddlPlan.DataSource = new PlanLogic().GetAll();
            ddlPlan.DataBind();
            ddlPlan.Items.Insert(0, "[Seleccionar]");
        }

        private void MapearForm(int id)
        {
            MateriaActual = MateriaLogic.GetOne(id);

            txtMateria.Text = MateriaActual.Descripcion;
            txtHorasSemanales.Text = MateriaActual.HorasSemanales.ToString();
            txtHorasTotales.Text = MateriaActual.HorasTotales.ToString();
            ddlPlan.SelectedValue = MateriaActual.Plan.ID.ToString();
        }

        private void MapearEntidad()
        {
            MateriaActual = MateriaLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    MateriaActual = new Materia { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
            }
            MateriaActual.Descripcion = txtMateria.Text;
            MateriaActual.HorasSemanales = int.Parse(txtHorasSemanales.Text);
            MateriaActual.Plan = new PlanLogic().GetOne(int.Parse(ddlPlan.SelectedValue));
            MateriaActual.HorasTotales = int.Parse(txtHorasTotales.Text);
        }

        private void SaveEntity(int id)
        {
            try
            {
                MateriaActual = MateriaLogic.GetOne(id);
                MapearEntidad();
                MateriaLogic.Save(MateriaActual);
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
                this.gvMaterias.DataSource = MateriaLogic.GetAll();
                this.gvMaterias.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de la materia.");
            }
        }
    }
}