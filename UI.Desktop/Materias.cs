using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;


namespace UI.Desktop
{
    public partial class Materias : ApplicationForm
    {
        public Materias()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            new MateriaDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvMaterias))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvMaterias))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvMaterias.DataSource = new MateriaLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de las materias",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
