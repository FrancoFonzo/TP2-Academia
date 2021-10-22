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
    public partial class Usuarios : Base
    {
        private static UsuarioLogic UsuarioLogic = new UsuarioLogic();

        private Usuario UsuarioActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvUsuarios.SelectedValue;
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                EnableForm(true);
                formPanel.Visible = true;
                Modo = ModoForm.Modificacion;
                LoadForm(SelectedID);
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Revisar returns, breaks, y save en baja.
            UsuarioActual = UsuarioLogic.GetOne(SelectedID);

            switch (Modo)
            {
                case ModoForm.Baja:
                    UsuarioActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    UsuarioActual = new Usuario { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
            }

            LoadEntity(UsuarioActual);
            SaveEntity(UsuarioActual);
            LoadGrid();
            formPanel.Visible = false;
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                formPanel.Visible = true;
                Modo = ModoForm.Baja;
                EnableForm(false);
                LoadForm(SelectedID);
            }
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            Modo = ModoForm.Alta;
            this.ClearForm();
            EnableForm(true);
        }

        protected void linkCancelar_Click(object sender, EventArgs e)
        {
            gridPanel.Visible = true;
        }

        private void LoadGrid()
        {
            try
            {
                this.gvUsuarios.DataSource = UsuarioLogic.GetAll();
                this.gvUsuarios.DataBind();
            }
            catch (Exception)
            {
            }
        }

        private void LoadForm(int id)
        {
            UsuarioActual = UsuarioLogic.GetOne(id);
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtClave.Text = UsuarioActual.Clave;
            chkHabilitado.Checked = UsuarioActual.Habilitado;
        }

        private void LoadEntity(Usuario usuario)
        {
            //TODO:añadir cbxPersona
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Clave = txtClave.Text;
            usuario.Habilitado = chkHabilitado.Checked;
        }

        private void SaveEntity(Usuario usuario)
        {
            UsuarioLogic.Save(usuario);
        }

        private void EnableForm(bool enable)
        {
            txtUsuario.Enabled = enable;
            txtClave.Visible = enable;
            lblClave.Visible = enable;
            lblRepetirClave.Visible = enable;
            txtRepetirClave.Visible = enable;
            //chkHabilitado.Enabled = enable;
        }

        private void ClearForm()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty; //??
            txtRepetirClave.Text = string.Empty; //??
            chkHabilitado.Checked = false;
        }
    }
}