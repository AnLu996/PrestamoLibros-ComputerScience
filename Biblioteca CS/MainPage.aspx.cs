using Biblioteca_CS.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca_CS
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void DropDownList()
        {
            String[] carreras = ServiceCall();
            Array.Sort(carreras);
            carrera.Items.Add("Selecciona una opcion");
            for (int i = 0; i < carreras.Length; i++)
            {
                string s = carreras[i];
                carrera.Items.Add(s);
            }

        }
        private String[] ServiceCall()
        {
            ServiceProject1Client client = new ServiceProject1Client();
            
            String[] carreras = client.getCarreras();

            return carreras;
        }
        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {
            string aname = nombre.Text;
            string alastname = apellido.Text;
            string amail = email.Text;
            int acui = int.Parse(cui.Text);
            int acarrera = carrera.SelectedIndex;
            bool aestud = estudiante.Checked;
            bool adocen = docente.Checked;
            bool aegre = egresado.Checked;
            string apass1 = password.Text;
            string apass2 = password2.Text;

            string rol = " ";
            if (aestud)
            {
                rol = "Estudiante";
            }
            else if (adocen)
            {
                rol = "Docente";
            }
            else
            {
                rol = "Egresado";
            }

            string truepassword = " ";
            if (apass2 == apass1) {
                truepassword = apass2; 
            }

            ServiceProject1Client client = new ServiceProject1Client();
            client.RegistroUsuario(aname, alastname, acui, amail, acarrera, rol, truepassword);
            CreateSession(aname, alastname, acui);
            CreateCookie(amail, rol); //CORREGIR
            Limpiar();
        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
        protected void Limpiar()
        {
            nombre.Text = string.Empty;
            apellido.Text = string.Empty;
            email.Text = string.Empty;
            cui.Text = string.Empty; //DUDAS
            estudiante.Checked = false;
            docente.Checked = false;
            egresado.Checked = false;
            carrera.SelectedIndex = 0;
            password.Text = string.Empty;
            password2.Text = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList();
            }
        }
        private void CreateSession(String nombre, String apellido, int cui)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellido;
            Session["CUI"] = cui;
        }
        private void CreateCookie(String email, String rol)
        {
            HttpCookie cookie1 = new HttpCookie("Email", email);
            Response.Cookies.Add(cookie1);
            HttpCookie cookie2 = new HttpCookie("Rol", rol);
            Response.Cookies.Add(cookie2);
        }

        [WebMethod]
        public static bool GetValidacion(String nombre, String apellidos, String mail, int cui)
        {
            ServiceProject1Client client = new ServiceProject1Client();
            return client.Existe_Registro(nombre, apellidos, mail, cui);
        }
    }

}