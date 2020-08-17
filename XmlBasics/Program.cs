using System;
using System.Xml;
using System.Collections.Generic;

namespace XmlBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>();

            XmlDocument document = new XmlDocument();
            document.Load("/Users/sanya/csharp_study/csharp_source/STEP_classwork/lesson_22/homework/XmlBasics/habr.xml");

            var rootElement = document.DocumentElement;
            foreach (XmlElement element in rootElement)
            {
                //var item = new Item();

                foreach (XmlNode childNode in element.ChildNodes)
                {
                    /*if (childNode.Name == "title")
                    {
                        item.Title = childNode.InnerText;
                    }
                    else if (childNode.Name == "link")
                    {
                        item.Link = childNode.InnerText;
                    }
                    else if (childNode.Name == "description")
                    {
                        item.Description = childNode.InnerText;
                    }
                    else if (childNode.Name == "pubDate")
                    {
                        item.PubDate = childNode.InnerText;
                    }*/
                    if (childNode.Name == "item")
                    {
                        var item = new Item();
                        foreach (XmlNode childChildNode in childNode)
                        {
                            if (childChildNode.Name == "title")
                            {
                                item.Title = childChildNode.InnerText;
                            }
                            else if (childChildNode.Name == "link")
                            {
                                item.Link = childChildNode.InnerText;
                            }
                            else if (childChildNode.Name == "description")
                            {
                                item.Description = childChildNode.InnerText;
                            }
                            else if (childChildNode.Name == "pubDate")
                            {
                                item.PubDate = childChildNode.InnerText;
                            }
                        }

                        items.Add(item);
                    }
                }
                // item.Title = element.Attributes["title"].Value;
                // item.Link = element.Attributes["link"].Value;
                // item.Discription = element.Attributes["discription"].Value;
                // item.PubDate = element.Attributes["pubDate"].Value;

                /*item.Title = element.ChildNodes[0].InnerText;
                item.Link = element.ChildNodes[1].InnerText;;
                item.Discription = element.ChildNodes[2].InnerText;;
                item.PubDate = element.ChildNodes[6].InnerText;;*/

                //items.Add(item);
            }
            
            foreach (var item in items)
            {
                Console.WriteLine($"TITLE: {item.Title}");
                Console.WriteLine($"LINK: {item.Link}");
                Console.WriteLine($"DESCRIPTION: {item.Description}");
                Console.WriteLine($"PUB DATE: {item.PubDate}");
            }
        }
    }
}
