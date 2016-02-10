using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = new HttpCookie("myCookieId");
            myCookies["Name"] = TextBox1.Text;
            myCookies.Expires = DateTime.Now.AddHours(2);
            Response.Cookies.Add(myCookies);
            Response.Redirect("Services.aspx");
        }
    }
}