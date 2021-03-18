using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LUG_PIM3_Ana_Laura_Moyano.DAL.Xml
{
    public class XmlHelper : IXml
    {
        public T Deserialize<T>(string xml)
        {
            TextReader reader = new StringReader(xml);
            XmlSerializer s = new XmlSerializer(typeof(T));
            return (T)s.Deserialize(reader);
        }

        public string Serialize<T>(T o)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            s.Serialize(ms, o);
            return Encoding.ASCII.GetString(ms.ToArray());
        }
    }
}
