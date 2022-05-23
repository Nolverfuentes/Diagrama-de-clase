using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagrama_de_clase
{
    public partial class Contact : Page
    {
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
    }
}