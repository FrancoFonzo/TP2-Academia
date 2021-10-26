 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

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
            
                ShowForm(true);
            }

            protected void linkEditar_Click(object sender, EventArgs e)
            {
                if (IsRowSelected())
                {
                    Modo = ModoForm.Modificacion;
                  
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
            }

            protected void linkEliminar_Click(object sender, EventArgs e)
            {
                if (IsRowSelected())
                {
                    Modo = ModoForm.Baja;
                 
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
            }

            protected void linkAceptar_Click(object sender, EventArgs e)
            {
                this.Validate();
                if (this.IsValid)
                {
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

            
            private void MapearForm(int id)
            {
                EspecialidadActual = EspecialidadLogic.GetOne(id);

                txtDescripcion.Text = EspecialidadActual.Descripcion;
               
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
                    Notificar("Error al recuperar los daatos de la especialidad.");
                }
            }
        }
        
   }
