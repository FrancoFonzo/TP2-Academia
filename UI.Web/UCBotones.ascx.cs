using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class UCBotones : System.Web.UI.UserControl
    {
        public event EventHandler editar;
        public event EventHandler nuevo;
        public event EventHandler eliminar;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (this.editar != null)
                this.editar(this, EventArgs.Empty);
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            if (this.nuevo != null)
                this.nuevo(this, EventArgs.Empty);
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (this.eliminar != null)
                this.eliminar(this, EventArgs.Empty);
        }
    }
}