using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace LinqToXml
{
    class AsyncXml
    {
        public static async Task EditXmlDocumentAsync(string path)
        {
            XPathNodeIterator NodeIter;
            string strExpression;
            

            XmlDocument editableDocument = new XmlDocument(); // can edit
            editableDocument.Load(path);
            XPathNavigator editableNavigator = editableDocument.CreateNavigator();
            editableNavigator.SelectSingleNode("Students/Student[@id='1007']/Name").SetValue("Nhật Bình");
            await Task.Run(() => editableDocument.Save(path));
            strExpression = "/Students/Student";
            NodeIter = editableNavigator.Select(strExpression);
            Console.WriteLine("List of students(after edit):");

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                Console.WriteLine("Student name: {0}", NodeIter.Current.Value);
            };
        }

    }
}
