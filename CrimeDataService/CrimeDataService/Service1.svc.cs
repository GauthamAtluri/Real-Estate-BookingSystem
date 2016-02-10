using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
namespace CrimeDataService
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

        public int CrimeData(String ZipCode)
        {
            try
            {

                String url = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true" + "&zipcode=" + ZipCode; //appending the URL of the Restful Service and the input Zipcode

            
                int rate = 0; //Parameter to indicate CrimeRate
                WebRequest requestHttp = WebRequest.Create(url);        
                HttpWebResponse webResponse = (HttpWebResponse)requestHttp.GetResponse();
                StreamReader sReader = new StreamReader(webResponse.GetResponseStream());
                XmlDocument document = new XmlDocument();

                document.LoadXml(sReader.ReadToEnd());
                XmlNode node = document.DocumentElement.FirstChild;
                XmlNodeList noChild = node.ChildNodes;

             
                int count = 1;
               

                        rate = Convert.ToInt32(noChild[57].InnerText);   //CrimeData starts from 57th childElement to 63th.

                while(count !=10)
                {
                    rate += Convert.ToInt32(noChild[57 + count].InnerText);
                    count++;
                }
                        
                  
                return rate;


            }
            catch(Exception ex)
            {
                return 0;

            }
        }
    }
}
