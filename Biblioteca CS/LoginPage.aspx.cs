using Biblioteca_CS.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca_CS
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        
        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            string amail = email.Text;
            int acui = int.Parse(cui.Text);
            string password = contrasena.Text;
            ServiceProject1Client usuario = new ServiceProject1Client();
            bool UserCorrect = usuario.IniciarSesion(amail, acui, password);
            if (UserCorrect)
            {
                Session["Email"] = amail;
                Session["CUI"] = acui;
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                string mensaje = "Error al ingresar datos";
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('{mensaje}');", true);
            }
        }
    }
}