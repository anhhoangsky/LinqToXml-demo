using System;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace LinqToXml
{
    class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string path = @"D:\web\project_team\linqtoxml\linqtoxml\Data.xml";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            string strExpression;

            docNav = new XPathDocument(path);
            nav = docNav.CreateNavigator();
            strExpression = "count(/Students/Student)";
            Console.WriteLine("Si so: {0}", nav.Evaluate(strExpression));
            strExpression = "count(/Students/Student[Gender=1])";
            Console.WriteLine("Số lượng nam: {0}", nav.Evaluate(strExpression));
            strExpression = "count(/Students/Student[Gender=0])";
            Console.WriteLine("Số lượng nữ: {0}", nav.Evaluate(strExpression));
            strExpression = "count(/Students/Student[Gender=2])";
            Console.WriteLine("Số lượng không xác định: {0}", nav.Evaluate(strExpression));
            strExpression = "/Students/Student/Name";
            NodeIter = nav.Select(strExpression);
            Console.WriteLine("List of students:");
            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                Console.WriteLine("Student name: {0}", NodeIter.Current.Value);
            };


            //XmlDocument doc = LoadXmlDOM.Load(path);
            //Console.WriteLine("******************-------Loaded--------******************");
            //XmlNode root = doc.FirstChild.NextSibling.NextSibling;

            //Display the contents of the child nodes.
            //if (root.HasChildNodes)
            //{
            //    for (int i = 0; i < root.ChildNodes.Count; i++)
            //    {
            //        Console.WriteLine(root.ChildNodes[i].InnerText);
            //    }
            //}

            //DisplayXElements dis = new DisplayXElements();

            //dis.Display(doc, "Student");

            //Console.WriteLine("Nhap Ten Sinh Vien: ");
            //Console.ReadLine();
            //Console.WriteLine("Nhap lop: ");
            //Console.ReadLine();
            
        }
    }
}
