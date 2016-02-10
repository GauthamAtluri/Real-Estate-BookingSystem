using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using System.Xml;
using System.Net.Http;

namespace Assignment5.Pages
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            string url1 = @"http://10.1.12.42:43131/Service1.svc/encryption?text=" + TextBox3.Text;  //Creating Resource URI
            HttpClient client1 = new HttpClient(); 
            Task<string> finalResult1 = client1.GetStringAsync(url1);   //waiting for the final result

            string x1 = await finalResult1;
            string[] splitResult = x1.Split('>');     //Parsing XML doc
            string[] a = splitResult[1].Split('<');
            TextBox6.Text = a[0];
            Label9.Visible = true;
            TextBox6.Visible = true;

           
            
            string url3 = @"http://10.1.12.42:38367/Service1.svc/usernameValidate?username=" + TextBox2.Text;  //Creating Resource URI
            HttpClient client3 = new HttpClient();
            Task<string> finalResult3 = client3.GetStringAsync(url3);   //waiting for the final result
           
            string x3 = await finalResult3;
            Label5.Text = x3;
            Label5.Visible = true;

            string url4 = @"http://10.1.12.42:38367/Service1.svc/passwordValidate?password=" + TextBox3.Text;  //Creating Resource URI
            HttpClient client4 = new HttpClient();
            Task<string> finalResult4 = client4.GetStringAsync(url4);   //waiting for the final result

            string x4 = await finalResult4;
            Label6.Text = x4;
            Label6.Visible = true;

            string url5 = @"http://10.1.12.42:38367/Service1.svc/emailValidate?password?text=" + TextBox3.Text;  //Creating Resource URI
            HttpClient client5 = new HttpClient();
            Task<string> finalResult5 = client4.GetStringAsync(url5);   //waiting for the final result

            string x5 = await finalResult5;
            Label8.Text = x4;
            Label8.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
        }

        protected async void Button2_Click(object sender, EventArgs e)
        {
            string url2 = @"http://10.1.12.42:43131/Service1.svc/decryption?encryptedText=" + TextBox6.Text;  //Creating Resource URI
            HttpClient client2 = new HttpClient();
      
            Task<string> finalResult2 = client2.GetStringAsync(url2);   //waiting for the final result
            string x6 = await finalResult2;
            string[] splitResult = x6.Split('>');    //Parsing XML Result
            string[] a = splitResult[1].Split('<');
           
            TextBox7.Text = a[0];
            TextBox7.Visible = true;
            Label10.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home.aspx");
        }
    }
}