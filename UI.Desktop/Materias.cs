using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriasDesktop formMaterias = new MateriasDesktop(ApplicationForm.ModoForm.Alta);
            formMaterias.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!isRowSelected(dgvMaterias)) return;
            OpenForm(ApplicationForm.ModoForm.Modificacion);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!isRowSelected(dgvMaterias)) return;
            OpenForm(ApplicationForm.ModoForm.Baja);
        }

        private void OpenForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Materias)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriasDesktop formMaterias = new MateriasDesktop(ID, modo);
            formMaterias.ShowDialog();
            this.Listar();
        }
        public void Listar()
        {
            try
            {
                this.dgvMaterias.DataSource = new MateriaLogic().GetAll();
                
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
