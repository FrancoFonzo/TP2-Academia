using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Usuarios : ApplicationForm
    {
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        public override void Listar()
        {
            try
            {
                this.dgvUsuarios.DataSource = new UsuarioLogic().GetAll();               
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!isRowSelected(dgvUsuarios)) return;
            openUserForm(ApplicationForm.ModoForm.Modificacion);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!isRowSelected(dgvUsuarios)) return;
            openUserForm(ApplicationForm.ModoForm.Baja);
        }

        private void openUserForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, modo);
            formUsuario.ShowDialog();
            this.Listar();
        }
    }
}
