using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace LinqToXml
{
    class CreateXmlDOM
    {
        static public void Create(string path)
        {
            XDocument xmlStudents = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("List Of Student"),

                new XElement("Students",
                 new XElement("Student",
                            new XAttribute("id", 1005),
                            new XElement("Name", "Nguyễn Hoàng Anh"),
                            new XElement("Gender", "Nam"),
                            new XElement("Class", "K41E")
                        ),
                    new XElement("Student",
                            new XAttribute("id", 1006),
                            new XElement("Name", "Huỳnh Ngọc Bảo Phúc"),
                            new XElement("Gender", "Nam"),
                            new XElement("Class", "K41E")
                        ),
                    new XElement("Student",
                            new XAttribute("id", 1007),
                            new XElement("Name", "Võ Trần Nhật Bình"),
                            new XElement("Gender", "Nam"),
                            new XElement("Class", "K41E")
                        ),
                    new XElement("Student",
                            new XAttribute("id", 1008),
                            new XElement("Name", "Nguyễn Văn Diễn"),
                            new XElement("Gender", "Nam"),
                            new XElement("Class", "K41E")
                        ),
                    new XElement("Student",
                            new XAttribute("id", 1009),
                            new XElement("Name", "Nguyễn Minh Tâm"),
                            new XElement("Gender", "Nam"),
                            new XElement("Class", "K41E")
                        ))
            );
            //xmlStudents.Save(Console.Out);
            Console.WriteLine("Done!");
            xmlStudents.Save(path);
        }
    }
}
