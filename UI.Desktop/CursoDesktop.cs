using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso CursoActual { get; set; }

        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            MapearInicial();
        }

        public CursoDesktop(int id, ModoForm modo) : this(modo)
        {
            CursoActual = new CursoLogic().GetOne(id);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MapearInicial()
        {
            cbxMateria.DataSource = new MateriaLogic().GetAll();
            cbxComision.DataSource = new ComisionLogic().GetAll();

            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            txtID.Text = CursoActual.ID.ToString();
            txtDescripcion.Text = CursoActual.Descripcion;
            txtAñoCalendario.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();
            cbxMateria.SelectedValue = CursoActual.MateriaId;
            cbxComision.SelectedValue = CursoActual.ComisionId;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    CursoActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    CursoActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    CursoActual = new Curso { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;
            }
            CursoActual.AnioCalendario = int.Parse(txtAñoCalendario.Text);
            CursoActual.Cupo = int.Parse(txtCupo.Text);
            CursoActual.Materia = (Materia)cbxMateria.SelectedItem;
            CursoActual.Comision = (Comision)cbxComision.SelectedItem;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new CursoLogic().Save(CursoActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtCupo.Text, txtAñoCalendario.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxMateria.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La materia especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxComision.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La comision especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
