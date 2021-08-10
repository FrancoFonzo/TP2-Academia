using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        private Persona PersonaActual { get; set; }

        public PersonaDesktop()
        {
            InitializeComponent();
            cbxTipo.DataSource = new PersonaLogic().GetTipos();
            cbxPlan.DataSource = new PlanLogic().GetAll();
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PersonaDesktop(int ID, ModoForm modo) : this(modo)
        {
            PersonaActual = new PersonaLogic().GetOne(ID);
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
            txtID.Text = PersonaActual.ID.ToString();
            txtLegajo.Text = PersonaActual.Legajo.ToString();
            txtNombre.Text = PersonaActual.Nombre;
            txtApellido.Text = PersonaActual.Apellido;
            txtEMail.Text = PersonaActual.EMail;
            txtDireccion.Text = PersonaActual.Direccion;
            txtTelefono.Text = PersonaActual.Telefono;
            dateNacimiento.Value = PersonaActual.FechaNacimiento;
            cbxTipo.SelectedIndex = (int)PersonaActual.Tipo;
            cbxPlan.SelectedValue = PersonaActual.MiPlan.ID;

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
                PersonaActual = new Persona { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    PersonaActual.State = BusinessEntity.States.Modified;
                }
                PersonaActual.Legajo = int.Parse(txtLegajo.Text);
                PersonaActual.Nombre = txtNombre.Text;
                PersonaActual.Apellido = txtApellido.Text;
                PersonaActual.EMail = txtEMail.Text;
                PersonaActual.Direccion = txtDireccion.Text;
                PersonaActual.Telefono = txtTelefono.Text;
                PersonaActual.Tipo = (Persona.TiposPersonas)cbxTipo.SelectedIndex;
                PersonaActual.FechaNacimiento = dateNacimiento.Value;
                PersonaActual.MiPlan = new PlanLogic().GetOne((int)cbxPlan.SelectedValue);
            }
            else if (Modo == ModoForm.Baja)
            {
                PersonaActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                PersonaActual.State = BusinessEntity.States.Unmodified;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new PersonaLogic().Save(PersonaActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> {txtNombre.Text, txtApellido.Text, txtEMail.Text,
                    txtDireccion.Text, txtTelefono.Text, dateNacimiento.Text}))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarRegexNyA(txtNombre.Text) || !Validaciones.ValidarRegexNyA(txtApellido.Text))
            {
                Notificar("Informacion invalida", "Porfavor ingrese su nombre y apellido correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarRegexEmail(txtEMail.Text))
            {
                Notificar("Informacion invalida", "Porfavor ingrese un email valido.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxTipo.SelectedItem == null)
            {
                Notificar("Informacion invalida", "Porfavor ingrese un tipo de persona valido.",
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
