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
    public partial class Especialidades : Base
    {
        private static EspecialidadLogic EspecialidadLogic = new EspecialidadLogic();

        private Especialidad EspecialidadActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ValidaSesion();
                Listar();
            }
        }

        protected void gvEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvEspecialidad.SelectedValue;
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
            txtDescripcion.Text = string.Empty;
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
        }

        private void MapearForm(int id)
        {
            EspecialidadActual = EspecialidadLogic.GetOne(id);

            txtDescripcion.Text = EspecialidadActual.Descripcion;
        }

        private void MapearEntidad()
        {
            EspecialidadActual = EspecialidadLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    EspecialidadActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    EspecialidadActual = new Especialidad { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
            }
            EspecialidadActual.Descripcion= txtDescripcion.Text;
        }

        private void SaveEntity(int id)
        {
            EspecialidadActual = EspecialidadLogic.GetOne(id);
            MapearEntidad();
            EspecialidadLogic.Save(EspecialidadActual);
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
                this.gvEspecialidad.DataSource = EspecialidadLogic.GetAll();
                this.gvEspecialidad.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de la especialidad.");
            }
        }
    }
}
