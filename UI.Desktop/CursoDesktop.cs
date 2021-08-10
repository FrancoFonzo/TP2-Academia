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
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso CursoActual { get; set; }

        public CursoDesktop()
        {
            InitializeComponent();
            this.cbxMateria.DataSource = new MateriaLogic().GetAll();
            this.cbxComision.DataSource = new ComisionLogic().GetAll();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoActual = new CursoLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtDescripcion.Text = this.CursoActual.Descripcion;
            this.txtAñoCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.cbxMateria.SelectedValue = this.CursoActual.MiMateria.ID;
            this.cbxComision.SelectedValue = this.CursoActual.MiComision.ID;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.CursoActual = new Curso { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.CursoActual.State = BusinessEntity.States.Modified;
                }

                this.CursoActual.Descripcion = this.txtDescripcion.Text;
                this.CursoActual.AnioCalendario = int.Parse(this.txtAñoCalendario.Text);
                this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                this.CursoActual.MiMateria = new MateriaLogic().GetOne((int)this.cbxMateria.SelectedValue);
                this.CursoActual.MiComision = new ComisionLogic().GetOne((int)this.cbxComision.SelectedValue);


            }
            else if (Modo == ModoForm.Baja) CursoActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) CursoActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new CursoLogic().Save(CursoActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string>
                        {txtDescripcion.Text, txtCupo.Text, txtAñoCalendario.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbxMateria.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La materia especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbxComision.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La comision especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return true;
            return false;
        }
    }
}
