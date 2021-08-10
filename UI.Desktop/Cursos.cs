using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Listar();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvCursos))
            {
                OpenForm(ApplicationForm.ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvCursos))
            {
                OpenForm(ApplicationForm.ModoForm.Baja);
            }
        }
        private void OpenForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop formCurso = new CursoDesktop(ID, modo);
            formCurso.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvCursos.DataSource = new CursoLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos de los cursos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
