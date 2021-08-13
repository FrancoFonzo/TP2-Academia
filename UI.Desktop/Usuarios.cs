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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new UsuarioDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvUsuarios))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvUsuarios))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            new UsuarioDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvUsuarios.DataSource = new UsuarioLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
