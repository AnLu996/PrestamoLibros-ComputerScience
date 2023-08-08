using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca_CS
{
    public partial class Prestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Deshabilitar el TextBox al cargar la página por primera vez
                FechaEntrega.Enabled = false;
                FechaPrestamo.Enabled = false;
            }
        }
    }
}