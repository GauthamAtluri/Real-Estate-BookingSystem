using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
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
    public String[] weatherservice(String zip)
    {
        try
        {

            gov.weather.graphical.ndfdXML Obj = new gov.weather.graphical.ndfdXML();                   // Using the service at http://graphical.weather.gov/xml/SOAP_server/ndfdXMLserver.php?wsdl 
            DateTime dateNow = DateTime.Now;
            String[] resultOutpt = new String[6];

            XmlDocument xDoc = new XmlDocument();                                                        //Xml Document is Created
            xDoc.LoadXml(Obj.LatLonListZipCode(zip));                                                    
            XmlNodeList nodeList = xDoc.SelectNodes("/dwml");                                                //XMl file is being parsed

            String latlon = nodeList[0].InnerText;                                                        // String contained the latitude and longitude is obtained

            String[] tSplit = latlon.Split(',');                                                          // Using comma as the splitting criteria for longitude and latitude
            String latit = tSplit[0];                                                                  //  latitude
            String longit = tSplit[1];                                                                 //longitude

            xDoc.LoadXml(Obj.NDFDgenByDay(Convert.ToDecimal(latit), Convert.ToDecimal(longit), DateTime.Today.Date, "6", "e", "24 hourly"));   // Xml containing 5days of weather forecast is obtained
            XmlNodeList gNode = xDoc.DocumentElement.SelectNodes("/dwml/data/parameters");                                                        // Parsing 
            String[] maximumTemp = new String[7];
            String[] minimumTemp = new String[7];
            XmlNodeList cNode = gNode[0].ChildNodes;                                                         // Child nodes are being accessed.

            int x = 0;
            for (int i = 0; i < cNode.Count; i++)
            {
                int q = 0;
                if (cNode[i].Name == "temperature" && x == 0)                                             // values of temperature accessed 

                {
                    XmlNodeList mValues = cNode[i].ChildNodes;                                          // values of maximum temp are stored
                    for (int j = 1; j < 6; j++)
                    {
                        maximumTemp[q] = mValues[j].InnerText;                                          
                        q++;
                    }
                    x = 1;
                }
                else if (cNode[i].Name == "temperature" && x == 1)                                         // valued of minimum temp are stored
                {
                    XmlNodeList mValues = cNode[i].ChildNodes;
                    for (int j = 1; j < 6; j++)
                    {
                        minimumTemp[q] = mValues[j].InnerText;                                                 
                        q++;
                    }
                }

            }


            for (int i = 0; i < 5; i++)
            {

                resultOutpt[i] = "Date: " + dateNow.ToString("d") + ", " + "Day: " + dateNow.DayOfWeek + "@Max Temp: " + maximumTemp[i] + "@Min Temp: " + minimumTemp[i];       // The Page called is receiving the data
                resultOutpt[i] = resultOutpt[i].Replace("@", System.Environment.NewLine);                                 
                dateNow = dateNow.AddDays(1);
            }

            return resultOutpt;                                                                          
        }
        catch (Exception)                                                           // exception Handling
        {
            String[] str = new String[1];
            str[0] = "ZipCode entered not valid";
            return str;
        }
    }
}
