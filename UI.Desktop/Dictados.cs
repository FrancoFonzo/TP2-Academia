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
    public partial class Dictados : ApplicationForm
    {
        public Dictados()
        {
            InitializeComponent();
            dgvDocentes.AutoGenerateColumns = false;
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new DictadoDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvDocentes))
            {
                OpenForm(ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected(dgvDocentes))
            {
                OpenForm(ModoForm.Baja);
            }
        }

        private void OpenForm(ModoForm modo)
        {
            int ID = ((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID;
            new DictadoDesktop(ID, modo).ShowDialog();
            Listar();
        }

        public override void Listar()
        {
            try
            {
                dgvDocentes.DataSource = new DocenteCursoLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de los dictados",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
