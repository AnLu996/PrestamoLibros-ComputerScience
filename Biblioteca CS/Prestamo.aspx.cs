using Biblioteca_CS.ServiceReference1;
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

        protected void Button_Registrar_Prestamo(object sender, EventArgs e)
        {
            string Title = titulo.Text;
            string Author = autor.Text;
            string FechaPres = FechaPrestamo.Text;
            string FechaEntre = FechaEntrega.Text;

            ServiceProject1Client prestamo = new ServiceProject1Client();
            //prestamo.RegistroPrestamo(Title, Author, FechaPres, FechaEntre);
            
            Limpiar();
        }

        protected void Limpiar()
        {
            titulo.Text = "";
            autor.Text = "";
        }
    }
}