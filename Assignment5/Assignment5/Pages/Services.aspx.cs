using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
namespace Assignment5.Pages
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if(myCookies != null ) Label2.Text = "Hello" + myCookies["Name"].ToString() + "!";


        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client crime = new ServiceReference1.Service1Client();
            string a = TextBox9.Text;
            int x= crime.CrimeData(a);
            TextBox10.Text = Convert.ToString(x);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.ServiceClient weather = new ServiceReference2.ServiceClient();

            string [] result = weather.weatherservice(TextBox1.Text);
            TextBox2.Text = result[0];
            TextBox3.Text = result[1];
            TextBox4.Text = result[2];
            TextBox5.Text = result[3];
            TextBox6.Text = result[4];
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service1Client fil = new ServiceReference3.Service1Client();

            TextBox8.Text = fil.WordFilter(TextBox7.Text);
        }
    }
}