﻿using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Especialidades : ApplicationForm
    {
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvEspecialidades))
            {
                openForm(ApplicationForm.ModoForm.Modificacion);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (isRowSelected(dgvEspecialidades))
            {
                openForm(ApplicationForm.ModoForm.Baja);
            }
        }

        private void openForm(ApplicationForm.ModoForm modo)
        {
            int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, modo);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        public override void Listar()
        {
            try
            {
                this.dgvEspecialidades.DataSource = new EspecialidadLogic().GetAll();
            }
            catch (Exception)
            {
                Notificar("Error", "Error al recuperar los datos del usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
