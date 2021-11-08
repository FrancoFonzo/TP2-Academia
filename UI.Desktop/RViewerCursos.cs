using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class RepViewer : ApplicationForm
    {
        public RepViewer()
        {
            InitializeComponent();
            
        }

        public void RepViewer_Load(object sender, EventArgs e)
        {
            try
            {
                cbx1.DataSource = new CursoLogic().GetAll();
            }
            catch(Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DSCursos.EnforceConstraints = false;
            try
            {
                this.CursoTableAdapter.Fill(this.DSCursos.Curso, ((Curso)cbx1.SelectedItem).ID);
            }
            catch(Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
            this.rv1.RefreshReport();
        }

        private void lblcb_Click(object sender, EventArgs e)
        {

        }
    }
}
