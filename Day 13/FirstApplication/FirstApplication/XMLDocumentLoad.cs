using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day13
{
    internal class XmlDOcumenyLoad
    {
        public static void Main2()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string filename = "C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 13\\FirstApplication\\books.xml";
            xmlDoc.Load(filename);
            xmlDoc.Save(Console.Out);

            Console.WriteLine("\n =============================");

            XmlDocument xmlDoc1 = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 13\\FirstApplication\\books.xml");
            xmlDoc1.Load(reader);
            xmlDoc1.Save(Console.Out);

            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 13\\FirstApplication\\domTest.xml", null);
            writer.Formatting = Formatting.Indented; ;
            //xmlDoc.Save(writer);

            XmlDocumentFragment xoc = xmlDoc.CreateDocumentFragment();
            xoc.InnerXml = "<Record>write some demo sample text</Record>";
            Console.WriteLine(xoc.InnerXml);

            XmlNode root = xmlDoc.DocumentElement;
            root.AppendChild(xoc);
            xmlDoc.Save(writer);
        }
    }
}
