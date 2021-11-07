using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using Util;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario Usuario { get; set; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
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

        public UsuarioDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                Usuario = new UsuarioLogic().GetOne(id);
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
            cbxPersona.DataSource = new PersonaLogic().GetAllSinUsuario();

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
            List<Persona> personas = new PersonaLogic().GetAllSinUsuario();
            personas.Add(Usuario.Persona);
            cbxPersona.DataSource = personas;

            txtID.Text = Usuario.ID.ToString();
            chkHabilitado.Checked = Usuario.Habilitado;
            txtUsuario.Text = Usuario.NombreUsuario;
            txtClave.Text = Usuario.Clave;
            cbxPersona.SelectedItem = Usuario.Persona;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    Usuario.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    Usuario.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    Usuario = new Usuario { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    Usuario.State = BusinessEntity.States.Modified;
                    break;
            }
            Usuario.Habilitado = chkHabilitado.Checked;
            Usuario.NombreUsuario = txtUsuario.Text;
            Usuario.Clave = txtClave.Text;
            Usuario.Persona = (Persona)cbxPersona.SelectedItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new UsuarioLogic().Save(Usuario);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtUsuario.Text, txtClave.Text, txtConfirmarClave.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.ValidarRegexClave(txtClave.Text))
            {
                Notificar("Contraseña invalida", "La contraseñas debe tener entre 4 y 50 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.UsuarioLengthValido(txtUsuario.Text))
            {
                Notificar("Usuario invalido", "El usuario debe ser menor a 16 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.UsuarioNoExiste(txtUsuario.Text))
            {
                Notificar("Usuario invalido", "El usuario ya existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Validaciones.ValidarClaveConfirmada(txtClave.Text, txtConfirmarClave.Text))
            {
                Notificar("Contraseña invalida", "Las contraseñas no coinciden.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
