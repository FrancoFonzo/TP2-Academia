using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario UsuarioActual { get; set; }

        public UsuarioDesktop()
        {
            InitializeComponent();
            //this.cbxPersona.DataSource = new PersonaLogic().GetPersonasSinUsuario();
            this.cbxPersona.DataSource = new PersonaLogic().GetAll();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            this.UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.cbxPersona.SelectedIndex = this.UsuarioActual.MiPersona.ID-1;
            //this.cbxPersona.Text = this.UsuarioActual.NombrePersona;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos() 
        {
            if (Modo == ModoForm.Alta)
            {
                this.UsuarioActual = new Usuario() { State = BusinessEntity.States.New };
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                }
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;

                var idPer = this.cbxPersona.SelectedValue;
                if (idPer == null) this.UsuarioActual.MiPersona = null;
                else this.UsuarioActual.MiPersona = new PersonaLogic().GetOne((int)idPer);
                /*if (idPer == null) return;
                if (int.TryParse(idPer.ToString(), out int id))
                {
                    this.UsuarioActual.MiPersona = new PersonaLogic().GetOne(id);
                }*/
            }
            else if (Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) UsuarioActual.State = BusinessEntity.States.Unmodified; 
        }
        
        public override void GuardarCambios() 
        {
            MapearADatos();
            new UsuarioLogic().Save(UsuarioActual);
        }

        public override bool Validar() 
        {
            if (!Validaciones.FormularioCompleto( new List<string>
                        {txtUsuario.Text, txtClave.Text, txtConfirmarClave.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Validaciones.ValidarRegexClave(txtClave.Text))
            {
                Notificar("Contraseña invalida", "La contraseñas debe tener entre 4 y 50 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtUsuario.Text.Length < 16))
            {
                Notificar("Usuario invalido", "El usuario debe ser menor a 16 caracteres.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validaciones.ValidarClaveConfirmada(txtClave.Text, txtConfirmarClave.Text))
            {
                Notificar("Contraseña invalida", "Las contraseñas no coinciden.",
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
