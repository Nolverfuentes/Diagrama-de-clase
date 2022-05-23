using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagrama_de_clase
{
    public partial class Contact : Page
    {
        public List<Producto> productos = new List<Producto>();
        public string Imagen;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //obtener la identidad del usuario acutalmente logueado
            var identidad = (FormsIdentity)Context.User.Identity;


            if (identidad.Ticket.UserData != "1")
            {
                //Si el usuario no tiene permitido entrar a esta página, lo redirigimos a una página en la que si tenga permiso
                Response.Redirect("Default", true);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string archivoOrigen = Path.GetFileName(FileUpload1.FileName);
            try
            {
                FileUpload1.SaveAs(Server.MapPath("~/imagenes/") + archivoOrigen);
            }
            catch (Exception ex)
            {

            }
            string archivo = "~/imagenes/" + FileUpload1.FileName;
            Producto p = new Producto();
            p.Imagen = archivo;
            productos.Add(p);
            GridView1.DataSource = productos;
            GridView1.DataBind();

        }
    }
}