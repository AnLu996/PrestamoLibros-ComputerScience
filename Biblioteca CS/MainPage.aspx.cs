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
        protected void Button_Enviar_Click(object sender, EventArgs e)
        {
            string Name = nombre.Text;
            string Lastname = apellido.Text;
            string Email = email.Text;
            int Cui = int.Parse(cui.Text);
            int Carrera = carrera.SelectedIndex;
            string Rol = estudiante.Checked ? "Estudiante" : (docente.Checked ? "Docente" : "Egresado");
            string pass1 = password.Text;
            string pass2 = password2.Text;
            string truepassword = "";
            if (!string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2) && pass2 == pass1)
            {
                truepassword = pass2;
            }

            ServiceProject1Client client = new ServiceProject1Client();
            client.RegistroUsuario(Name, Lastname, Cui, Email, Carrera, Rol, truepassword);
            Console.Write("Datos Enviados Correctamente");
            CreateSession(Name, Lastname, Cui);
            CreateCookie(Email, Rol);
            Limpiar();
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
        protected void Limpiar()
        {
            nombre.Text = "";
            apellido.Text = "";
            email.Text = "";
            cui.Text = ""; 
            estudiante.Checked = false;
            docente.Checked = false;
            egresado.Checked = false;
            carrera.SelectedIndex = 0;
            password.Text = "";
            password2.Text = "";
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