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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }

        public UsuarioDesktop()
        {
            InitializeComponent();
            PersonaLogic perLogic = new PersonaLogic();
            this.cbxPersona.DataSource = perLogic.GetAll();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usrLogic = new UsuarioLogic();
            UsuarioActual = usrLogic.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos() 
        {
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.State = BusinessEntity.States.New;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    UsuarioActual.State = BusinessEntity.States.Modified;
                }
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                // Esta bien?
                try
                {
                    int id;
                    bool parsed = int.TryParse(this.cbxPersona.SelectedValue.ToString(), out id);
                    //this.cbxPersona.SelectedValue == null -> no se asigna ninguna persona
                    if (parsed)
                    {
                        PersonaLogic perLogic = new PersonaLogic();
                        this.UsuarioActual.MiPersona = perLogic.GetOne(id);
                    }
                }
                catch (NullReferenceException) { }  
            }
            else if (Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) UsuarioActual.State = BusinessEntity.States.Unmodified; 
        }
        
        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usrLogic = new UsuarioLogic();
            usrLogic.Save(UsuarioActual);
        }

        public override bool Validar() 
        {
            if (!Validaciones.FormularioCompleto(
                    new List<string> {txtUsuario.Text, txtClave.Text, txtConfirmarClave.Text }))
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /*
            if (!Validaciones.ValidarNyA(txtNombre.Text) || !Validaciones.ValidarNyA(txtApellido.Text))
            {
                Notificar("Nombre o Apellido invalido", "Porfavor ingrese su nombre y apellido correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.ValidarEmail(txtEmail.Text))
            {
                Notificar("Email invalido", "Porfavor ingrese un email valido.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */
            if (!Validaciones.ValidarRegexClave(txtClave.Text))
            {
                Notificar("Contraseña invalida", "La contraseñas debe tener entre 4 y 50 caracteres.",
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
