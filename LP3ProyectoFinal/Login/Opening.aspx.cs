using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LP3ProyectoFinal.Login
{
    public partial class Opening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "redir", "setTimeout(function(){ window.location='Login.aspx'; }, 3100);", true);
            }
        }
    }
}