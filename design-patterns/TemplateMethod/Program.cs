using System;
using System.IO;
using System.Reflection;
using System.Xml;
using TemplateMethod.Handles;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\example.txt");

            TxtToXmlConverter txtToXmlConverter = new TxtToXmlConverter();
            XmlDocument doc = txtToXmlConverter.FormatTxt(path);

            Console.WriteLine(doc.InnerText);
        }
    }
}
