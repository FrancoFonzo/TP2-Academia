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
        public UsuarioDesktop()
        {
            InitializeComponent();
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

        public Usuario UsuarioActual { get; set; }

        //override?
        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos() 
        {
            if(Modo == ModoForm.Alta) UsuarioActual = new Usuario();

            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo != ModoForm.Alta) this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.EMail = this.txtEmail.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
            }
            
            if (Modo == ModoForm.Alta) UsuarioActual.State = BusinessEntity.States.New;
            if (Modo == ModoForm.Baja) UsuarioActual.State = BusinessEntity.States.Deleted;
            //if (Modo == ModoForm.Consulta) UsuarioActual.State = BusinessEntity.States.Unmodified;// Consulta actualiza State a Unmodified?
            if (Modo == ModoForm.Modificacion) UsuarioActual.State = BusinessEntity.States.Modified;
        }

        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usrLogic = new UsuarioLogic();
            usrLogic.Save(UsuarioActual);
        }

        public override bool Validar() 
        {
            if (txtNombre.Text.Equals(String.Empty) ||
                txtApellido.Text.Equals(String.Empty) ||
                txtEmail.Text.Equals(String.Empty) ||
                txtUsuario.Text.Equals(String.Empty) ||
                txtClave.Text.Equals(String.Empty) ||
                txtConfirmarClave.Text.Equals(String.Empty))
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txtClave.Text.Equals(txtConfirmarClave.Text))
            {
                Notificar("Contraseña invalida", "Las contraseñas no coinciden.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
