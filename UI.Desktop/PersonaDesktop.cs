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
            this.cbxTipo.DataSource = new PersonaLogic().GetTipos();
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PersonaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            this.PersonaActual = new PersonaLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtEMail.Text = this.PersonaActual.EMail;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.dateNacimiento.Value = this.PersonaActual.FechaNacimiento;
            this.cbxTipo.SelectedIndex = (int) this.PersonaActual.Tipo;
            
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.PersonaActual = new Persona() { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.PersonaActual.ID = int.Parse(this.txtID.Text);
                    this.PersonaActual.State = BusinessEntity.States.Modified;
                }
                this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                this.PersonaActual.Nombre = this.txtNombre.Text;
                this.PersonaActual.Apellido = this.txtApellido.Text;
                this.PersonaActual.EMail = this.txtEMail.Text;
                this.PersonaActual.Direccion = this.txtDireccion.Text;
                this.PersonaActual.Telefono = this.txtTelefono.Text;
                this.PersonaActual.Tipo = (Persona.TiposPersonas) this.cbxTipo.SelectedIndex;
            }
            else if (Modo == ModoForm.Baja) PersonaActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) PersonaActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new PersonaLogic().Save(PersonaActual);
        }
        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string>
                        {txtNombre.Text, txtApellido.Text, txtEMail.Text, txtDireccion.Text,
                txtTelefono.Text, dateNacimiento.Text, cbxTipo.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarRegexNyA(txtNombre.Text) || !Validaciones.ValidarRegexNyA(txtApellido.Text))
            {
                Notificar("Nombre o Apellido invalido", "Porfavor ingrese su nombre y apellido correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!Validaciones.ValidarRegexEmail(txtEMail.Text))
            {
                Notificar("Email invalido", "Porfavor ingrese un email valido.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxTipo.SelectedItem == null)
            {
                Notificar("Informacion invalida", "Porfavor ingrese un tipo de persona valido.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return true;

            return false;
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
    }
}
