using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies == null) || (myCookies["Name"] == ""))
            {
                Label1.Text = "Hello, guest!";
                
            }
            else
            {
                Label1.Text = "Hello, " + myCookies["Name"] + "!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pages/Login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pages/Registration.aspx");
        }
    }
}