using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
namespace Validate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        //The below service is used for validating the emailId entered by the user
        public bool emailValidate(string text)
        {
            try
            {
                Regex expression = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");  //Regular expression for validating emailID
                Match regMatch = expression.Match(text);
                return regMatch.Success;
            }
            catch (Exception ex)     //Exception Handling
            {
                return false;
            }
           
        }
        //This service below is used for validating the password entered by the user. Should be Between 8-15 in length and should contain atleast 1 special character.
        public bool passwordValidate(string password)
        {
            try
            {
                Regex expression = new Regex("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{8,15})$"); //Regular Expression for Validating password
                Match regMatch = expression.Match(password);
                return regMatch.Success;   //return true if match

            }
            catch (Exception ex) //exception handling
            {
                return false;
            }
        }

        //The Below service is used for validating the username entered by the user. Should be between 6-15 characters in length
        public bool usernameValidate(string username)
        {
            try
            {

                if (username.Length < 6) return false; //if less than 6 characters return false;
                if (username.Length > 15) return false;  //if more than 15 characters return false;
                return true;       //return true if in between 6-15
            }

            catch (Exception ex)
            {
                return false;
            }
        
        }}

        
     
}