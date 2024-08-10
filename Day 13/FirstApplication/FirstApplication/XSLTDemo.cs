using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Day_13
{
    internal class XSLTDemo
    {
        public static void Main11()
        {
            XslTransform xslt = new XslTransform();
            xslt.Load("C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 13\\FirstApplication\\FirstApplication\\SampleXSL.xslt");
            xslt.Transform("C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 13\\FirstApplication\\FirstApplication\\Books.xml", "file.html");
        }
    }
}