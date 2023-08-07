using Biblioteca_CS.ServiceReference1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca_CS
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*private void CargarDatosEnGridView()
        {
            ServiceProject1Client servicioDatos = new ServiceProject1Client();
            List<Registro> registros = servicioDatos.ObtenerDatos();

            // Agregar más datos al objeto Registro o modificar los datos existentes según tus necesidades
            foreach (Registro registro in registros)
            {
                registro.PropiedadAdicional = ObtenerDatosAdicionales(registro.Id);
            }

            gridView.DataSource = registros;
            gridView.DataBind();
        }*/
    }
}