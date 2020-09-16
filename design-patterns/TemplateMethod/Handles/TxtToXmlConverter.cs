using System.IO;
using System.Xml;
using TemplateMethod.Abstract;

namespace TemplateMethod.Handles
{
    public class TxtToXmlConverter : TxtConverterTemplate<XmlDocument>
    {
        internal override XmlDocument Convert(byte[] fileBytes)
        {
            XmlDocument doc = new XmlDocument();
            MemoryStream ms = new MemoryStream(fileBytes);
            doc.Load(ms);

            return doc;
        }
    }
}
