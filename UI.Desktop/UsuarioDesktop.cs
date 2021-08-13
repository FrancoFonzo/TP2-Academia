using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario Usuario { get; set; }

        public UsuarioDesktop()
        {
            InitializeComponent();
            List<Persona> personas = new PersonaLogic().GetPersonasSinUsuario();
            personas.Add(Usuario?.MiPersona);
            cbxPersona.DataSource = personas;
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public UsuarioDesktop(int id, ModoForm modo) : this(modo)
        {
            Usuario = new UsuarioLogic().GetOne(id);
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
            txtID.Text = Usuario.ID.ToString();
            chkHabilitado.Checked = Usuario.Habilitado;
            txtUsuario.Text = Usuario.NombreUsuario;
            txtClave.Text = Usuario.Clave;
            if (Usuario.MiPersona != null)
            {
                cbxPersona.SelectedValue = Usuario.MiPersona.ID;
            }

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

            var idPer = cbxPersona.SelectedValue;
            Usuario.MiPersona = idPer == null ?
                null : new PersonaLogic().GetOne((int)idPer);
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new UsuarioLogic().Save(Usuario);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtUsuario.Text, txtClave.Text, txtConfirmarClave.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarRegexClave(txtClave.Text))
            {
                Notificar("Contraseña invalida", "La contraseñas debe tener entre 4 y 50 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text.Length >= 16)
            {
                Notificar("Usuario invalido", "El usuario debe ser menor a 16 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarClaveConfirmada(txtClave.Text, txtConfirmarClave.Text))
            {
                Notificar("Contraseña invalida", "Las contraseñas no coinciden.",
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
