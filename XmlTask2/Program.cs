using System;
using System.Xml;

namespace XmlTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_22/homework/XmlTask2/student.xml");
            XmlElement root = document.DocumentElement;
            foreach (XmlNode node in root)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "name")
                    {
                        Console.WriteLine($"Name: {childNode.InnerText}");
                    }
                    else if (childNode.Name == "group")
                    {
                        Console.WriteLine($"Group: {childNode.InnerText}");
                    }
                    else if (childNode.Name == "age")
                    {
                        Console.WriteLine($"Age: {childNode.InnerText}");
                    }
                }
            }
        }
    }
}
