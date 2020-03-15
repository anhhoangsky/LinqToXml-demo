using System;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        private static void Main()
        {
            //CreateXmlDOM.Create();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string path = @"D:\web\project_team\linqtoxml\linqtoxml\Data.xml";

            XmlDocument doc = LoadXmlDOM.Load(path);
            Console.WriteLine("Loaded");
            XmlNode root = doc.FirstChild.NextSibling.NextSibling;

            //Display the contents of the child nodes.
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    Console.WriteLine(root.ChildNodes[i].InnerText);
                }
            }
        }
    }
}
