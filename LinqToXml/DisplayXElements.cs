using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXml
{
    class DisplayXElements
    {
        public void Display(XmlDocument root, string name)
        {
            XmlNodeList child = root.GetElementsByTagName(@name);
            for (int i = 0; i < child.Count; i++)
            {
                Console.WriteLine(child[i].InnerText);
            }
        }
    }
}
