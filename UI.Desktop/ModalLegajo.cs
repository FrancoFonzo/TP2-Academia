using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ModalLegajo : ApplicationForm
    {
        public ModalLegajo()
        {
            InitializeComponent();
        }

        public int Legajo { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Legajo = int.Parse(txtLegajo.Text);
            Close();
        }
    }
}
