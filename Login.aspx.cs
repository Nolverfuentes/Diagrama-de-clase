using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diagrama_de_clase
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            {
                string usuario = Login1.UserName;
                string password = Login1.Password;

                //En el proyecto final,  para esta comparación, deberá ir a buscar si el usuario y password están almacenados en un archivo JSON de usuarios.  
                if ((usuario == "ABC") && (password == "123"))
                {
                    FormsAuthenticationTicket tkt;//tkt ticket
                    string cookiestr;
                    HttpCookie ck;
                    tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                    DateTime.Now.AddMinutes(30), Login1.RememberMeSet, "1");
                    cookiestr = FormsAuthentication.Encrypt(tkt);
                    ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                    if (Login1.RememberMeSet)
                        ck.Expires = tkt.Expiration;
                    ck.Path = FormsAuthentication.FormsCookiePath;
                    Response.Cookies.Add(ck);

                    string strRedirect;
                    strRedirect = Request["ReturnUrl"];
                    if (strRedirect == null)
                        strRedirect = "Default.aspx";
                    
                   Response.Redirect(strRedirect, true);
                }
            }
        }
    }
}