using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceTry.Content
{
    public static class Shina
    {
        static string xml1 = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Customer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Name>Vasya</Name></Customer>";
        static string xml2 = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Customer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Id>14</Id><Name>Sasha</Name></Customer>";
        static string xml3 = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Customer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Id>52</Id><Name>Olya</Name></Customer>";
        public static List<string> XMLStrings = new List<string>()
        {
            xml1,
            xml2,
            xml3,
        };
    }
}
