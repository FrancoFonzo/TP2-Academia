using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class RViewerPlanes : ApplicationForm
    {
        public RViewerPlanes()
        {
            InitializeComponent();
        }

        private void RViewerPlanes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSCursos.Plan' Puede moverla o quitarla según sea necesario.

            cbx1.DataSource = new PlanLogic().GetAll();
            this.rv2.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DSCursos.EnforceConstraints = false;
            this.PlanTableAdapter.Fill(this.DSCursos.Plan, ((Plan)cbx1.SelectedItem).ID);          
            this.rv2.RefreshReport();
        }
    }
}
