using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using WebServiceTry.Content;
using WebServiceTry.Models;

namespace WebServiceTry
{
    /// <summary>
    /// Summary description for XMLService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XMLService : System.Web.Services.WebService
    {
        private CustomersEntities db = new CustomersEntities();
        [WebMethod]
        public string AddCustomer()
        {
            if (Shina.XMLStrings.Count != 0)
            {
                foreach (var i in Shina.XMLStrings)
                {
                    var xml = i;
                    XmlSerializer serial = new XmlSerializer(typeof(Customer));
                    StringReader reader = new StringReader(xml);
                    Customer nextCustomer = (Customer)serial.Deserialize(reader);
                    if (db.Customer.Find(nextCustomer.Id) == null)
                    {
                        db.Customer.Add(nextCustomer);
                    }
                    else
                    {
                        continue;
                    }
                }
                Shina.XMLStrings.Clear();
                db.SaveChanges();
                return "success";
            }
            else
            {
                return "Shina is empty";
            }
            

        }
        [WebMethod]
        public string GetXml()
        {
            if (db.Customer != null)
            {
                foreach (var customer in db.Customer)
                {
                    XmlSerializer xml = new XmlSerializer(customer.GetType());
                    var wfile = new StringWriter();
                    xml.Serialize(wfile, customer);
                    string InputXml = wfile.ToString();
                    Shina.XMLStrings.Add(InputXml);
                }
                return "success";
            }
            else
            {
                return "DataBase is empty";
            }
            
        }
    }
}
