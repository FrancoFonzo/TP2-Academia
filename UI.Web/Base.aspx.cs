using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Base : System.Web.UI.Page
    {

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion
        }

        public ModoForm Modo
        {
            get => (ModoForm)this.ViewState["FormMode"];
            set { this.ViewState["FormMode"] = value; }
        }

        protected int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set { this.ViewState["SelectedID"] = value; }
        }

        protected bool IsEntitySelected { get => this.SelectedID != 0; }
    }
}