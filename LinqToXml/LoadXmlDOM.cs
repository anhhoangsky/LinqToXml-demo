using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LinqToXml
{
    class LoadXmlDOM
    {
        public static XmlDocument Load(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Console.WriteLine(doc.DocumentElement.OuterXml);
            return doc;
        }
    }
}
