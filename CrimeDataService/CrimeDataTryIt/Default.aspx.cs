using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrimeDataTryIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client crimeObj = new ServiceReference1.Service1Client(); //Creating Service Proxy

            int cData;  //OutPut Field
            cData = crimeObj.CrimeData(TextBox1.Text);

            if (cData != 0)
            {
                TextBox2.Text = cData.ToString();
            }

            else
            {
                TextBox2.Text = "Please Enter a Valid ZipCode";
            }

        }
        }
    }
