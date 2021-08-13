using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Cursos : ApplicationForm
    {
        public Cursos()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new CursoDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvCursos))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvCursos))
            {
                OpenForm(ModoForm.Baja);
            }
        }
        private void OpenForm(ModoForm modo)
        {
            int ID = ((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID;
            new CursoDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvCursos.DataSource = new CursoLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de los cursos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
