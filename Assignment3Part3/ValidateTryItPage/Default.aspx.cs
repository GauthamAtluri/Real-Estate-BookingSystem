using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidateTryItPage
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
                Label7.Visible = false;
                ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
                bool result = obj.emailValidate(TextBox1.Text);
                if (result == true) Label7.Text = "Valid";
                else Label7.Text = "Invalid";
                Label7.Visible = true;


            }
            catch
            {
                Label7.Visible=true;
                Label7.Text = "Invalid";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try {
                Label13.Visible = false;
                ServiceReference1.Service1Client obj1 = new ServiceReference1.Service1Client();
                bool result = obj1.passwordValidate(TextBox2.Text);
                if (result == true) Label13.Text = "Valid";
                else Label13.Text = "Invalid";
                Label13.Visible = true;

            
            }
            catch {
                Label13.Text = "Invalid";
            
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try {
                Label19.Visible = false;
                ServiceReference1.Service1Client obj2 = new ServiceReference1.Service1Client();
                bool result = obj2.usernameValidate(TextBox3.Text);
                if (result == true) Label19.Text = "Valid";
                else Label19.Text = "Invalid";
                Label19.Visible = true;

            
            }
            catch {
                Label19.Visible = true;

                Label19.Text = "Invalid";
            
            }
        }
    }
}