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

namespace EncryptDecryptTryIT
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
          
            HttpClient client = new HttpClient();    //Http Client is Created

            string url1 = @"http://10.1.12.42:43131/Service1.svc/encryption?text=" + TextBox1.Text;  //Creating Resource URI

            Task<string> finalResult = client.GetStringAsync(url1);   //waiting for the final result

            string x = await finalResult;
            string[] splitResult = x.Split('>');     //Parsing XML doc
            string[] a = splitResult[1].Split('<');
            TextBox2.Text = a[0];
        }

        protected async void Button2_Click(object sender, EventArgs e)
        {
            try
            {
             
                HttpClient client = new HttpClient();       //Http Client is created

                string url1 = @"http://10.1.12.42:43131/Service1.svc/decryption?encryptedText=" + TextBox2.Text;   //Creating Resource URI

                Task<string> result = client.GetStringAsync(url1);   //Obtaining the result

                string x = await result;    //waiting till the result is obtained
                
                string[] splitResult = x.Split('>');    //Parsing XML Result
                string[] a = splitResult[1].Split('<');
                TextBox3.Text = a[0];
            }
            catch(Exception Ex )
            {
                TextBox3.Text = Ex.ToString();
            }

        }
    }
}