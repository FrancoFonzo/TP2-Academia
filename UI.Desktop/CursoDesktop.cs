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
            cbxMateria.DataSource = new MateriaLogic().GetAll();
            cbxComision.DataSource = new ComisionLogic().GetAll();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo) : this(modo)
        {
            CursoActual = new CursoLogic().GetOne(ID);
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

        public override void MapearDeDatos()
        {
            txtID.Text = CursoActual.ID.ToString();
            txtDescripcion.Text = CursoActual.Descripcion;
            txtAñoCalendario.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();
            cbxMateria.SelectedValue = CursoActual.MiMateria.ID;
            cbxComision.SelectedValue = CursoActual.MiComision.ID;

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                CursoActual = new Curso { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    CursoActual.State = BusinessEntity.States.Modified;
                }

                CursoActual.Descripcion = txtDescripcion.Text;
                CursoActual.AnioCalendario = int.Parse(txtAñoCalendario.Text);
                CursoActual.Cupo = int.Parse(txtCupo.Text);
                CursoActual.MiMateria = new MateriaLogic().GetOne((int)cbxMateria.SelectedValue);
                CursoActual.MiComision = new ComisionLogic().GetOne((int)cbxComision.SelectedValue);


            }
            else if (Modo == ModoForm.Baja)
            {
                CursoActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                CursoActual.State = BusinessEntity.States.Unmodified;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new CursoLogic().Save(CursoActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> {txtDescripcion.Text, txtCupo.Text, txtAñoCalendario.Text})
                )
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
