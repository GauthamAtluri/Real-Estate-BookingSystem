using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using System.Xml;


namespace WeatherForecastTryIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();         // Proxy Class
            String[] weatherForecast = new String[5];
            weatherForecast = obj.weatherservice(TextBox2.Text); // Forecast results being stored.
            
            Label6.Text = "";
            try
            {
                TextBox3.Text = weatherForecast[0];                                                         
                TextBox4.Text = weatherForecast[1];                                                       
                TextBox5.Text = weatherForecast[2];             
                TextBox6.Text = weatherForecast[3];             
                TextBox7.Text = weatherForecast[4];
                Label6.Visible = false;
            }
            catch
            {
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                Label6.Visible = true;
                Label6.Text = "Invalid Zipcode";
            }
        }
    }
}