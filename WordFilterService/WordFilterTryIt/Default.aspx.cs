using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordFilterTryIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                ServiceReference1.Service1Client filterObj = new ServiceReference1.Service1Client();  //creating Service Proxy
                       
                TextBox2.Text = filterObj.WordFilter(TextBox1.Text);                                                              // removing the stopwords and tags and writing output on the try it web page
            }
            catch
            {
                TextBox2.Text = "Entered Input is Invalid";
            }
        }
    }
}