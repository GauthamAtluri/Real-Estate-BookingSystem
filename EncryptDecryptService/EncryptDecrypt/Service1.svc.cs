using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Security.Cryptography;

// Using triple DES algorithm for encryption-decryption process.
namespace EncryptDecrypt
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
        private const string secureKey = "QaZ1wSx2Edc3RfV4"; //Important Security Key
        public string Encrypt(string text)
        {
            try
            {
              
                
                byte[] getBytes = UTF8Encoding.UTF8.GetBytes(text); //getting the string to encrypt

             
               

                System.Security.Cryptography.MD5CryptoServiceProvider cryptObj = new System.Security.Cryptography.MD5CryptoServiceProvider();

                byte[] computeHashArray = cryptObj.ComputeHash(UTF8Encoding.UTF8.GetBytes(secureKey));
                 

                    cryptObj.Clear();  //Releasing the object
               

                TripleDESCryptoServiceProvider tripleDESC = new TripleDESCryptoServiceProvider();  //creating an object of TRIPLE DES service provider
                
                tripleDESC.Key = computeHashArray;   //securekey is being set
             
              
                tripleDESC.Mode = CipherMode.ECB;  //Electronic Code Book mode is being set
                

                tripleDESC.Padding = PaddingMode.PKCS7;   //Padding

                ICryptoTransform ICT = tripleDESC.CreateEncryptor();
               
                byte[] transform = ICT.TransformFinalBlock(getBytes, 0,getBytes.Length);  //Byte Array to Transform array
         
                tripleDESC.Clear();   //release object
               
                return Convert.ToBase64String(transform, 0, transform.Length);   //return encrypted string
            
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string Decrypt(string encryptedString)
        {
            try
            {
             
               
               
                byte[] extractBytes = Convert.FromBase64String(encryptedString);   //getting the string to decrypt





                MD5CryptoServiceProvider descObj = new MD5CryptoServiceProvider();  //creating an instance of MD5CryptoServiceProvider
                   byte[] hashCompute = descObj.ComputeHash(UTF8Encoding.UTF8.GetBytes(secureKey));
                

                    descObj.Clear();  //releasing resourse
                
                
                TripleDESCryptoServiceProvider DESCD = new TripleDESCryptoServiceProvider();
              
                DESCD.Key = hashCompute;  //secure Key is being set
              
              

                DESCD.Mode = CipherMode.ECB;     //Electronic Code Book Mode
           
                DESCD.Padding = PaddingMode.PKCS7;  //Padding

                ICryptoTransform ICTransform = DESCD.CreateDecryptor();
                byte[] finalResult = ICTransform.TransformFinalBlock(                          //Transforming byte array to finalResult
                                     extractBytes, 0, extractBytes.Length);
                              
                DESCD.Clear();
            
                return UTF8Encoding.UTF8.GetString(finalResult);  //Return Decrypted Text
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
        }
  
    }
}
