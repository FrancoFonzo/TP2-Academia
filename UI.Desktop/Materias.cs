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
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMaterias = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMaterias.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvMaterias))
            {
                OpenForm(ApplicationForm.ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvMaterias))
            {
                OpenForm(ApplicationForm.ModoForm.Baja);
            }
        }

        private void OpenForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMaterias = new MateriaDesktop(ID, modo);
            formMaterias.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvMaterias.DataSource = new MateriaLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de las materias",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
