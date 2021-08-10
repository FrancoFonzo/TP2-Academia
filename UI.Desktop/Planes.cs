﻿using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Planes : ApplicationForm
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvPlanes))
            {
                openForm(ApplicationForm.ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvPlanes))
            {
                openForm(ApplicationForm.ModoForm.Baja);
            }
        }

        private void openForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlan = new PlanDesktop(ID, modo);
            formPlan.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvPlanes.DataSource = new PlanLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del plan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
