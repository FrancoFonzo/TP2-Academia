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
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            try
            {
                Modo = modo;
                MapearInicial();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PersonaDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                PersonaActual = new PersonaLogic().GetOne(id);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            cbxTipo.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
            cbxPlan.DataSource = new PlanLogic().GetAll();

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
            txtID.Text = PersonaActual.ID.ToString();
            txtLegajo.Text = PersonaActual.Legajo?.ToString();
            txtNombre.Text = PersonaActual.Nombre;
            txtApellido.Text = PersonaActual.Apellido;
            txtEMail.Text = PersonaActual.EMail;
            txtDireccion.Text = PersonaActual.Direccion;
            txtTelefono.Text = PersonaActual.Telefono;
            dateNacimiento.Value = PersonaActual.FechaNacimiento;
            cbxTipo.SelectedItem = PersonaActual.Tipo;
            if (PersonaActual.Plan != null)
            {
                cbxPlan.SelectedValue = PersonaActual.Plan.ID;
            }
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    PersonaActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    PersonaActual = new Persona { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
            }
            int.TryParse(txtLegajo.Text, out int legajo);
            if (!String.IsNullOrEmpty(txtLegajo.Text) && legajo < 0)
            {
                throw new Exception("El legajo sebe ser un numero positivo(alumno) o vacio(docente y admin).");
            }
            PersonaActual.Legajo = legajo;
            PersonaActual.Nombre = txtNombre.Text;
            PersonaActual.Apellido = txtApellido.Text;
            PersonaActual.EMail = txtEMail.Text;
            PersonaActual.Direccion = txtDireccion.Text;
            PersonaActual.Telefono = txtTelefono.Text;
            PersonaActual.Tipo = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), cbxTipo.SelectedItem.ToString());
            PersonaActual.FechaNacimiento = dateNacimiento.Value;
            PersonaActual.Plan = (Plan)cbxPlan.SelectedItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new PersonaLogic().Save(PersonaActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> {txtNombre.Text, txtApellido.Text, txtEMail.Text,
                    txtDireccion.Text, txtTelefono.Text, dateNacimiento.Text}))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.ValidarRegexNyA(txtNombre.Text) || !Validaciones.ValidarRegexNyA(txtApellido.Text))
            {
                Notificar("Informacion invalida", "Porfavor ingrese su nombre y apellido correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.ValidarRegexEmail(txtEMail.Text))
            {
                Notificar("Informacion invalida", "Porfavor ingrese un email valido.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxTipo.SelectedItem == null)
            {
                Notificar("Informacion invalida", "Porfavor ingrese un tipo de persona valido.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
