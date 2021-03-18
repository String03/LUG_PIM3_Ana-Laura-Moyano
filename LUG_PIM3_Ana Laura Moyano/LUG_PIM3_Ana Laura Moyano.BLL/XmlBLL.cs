using LUG_PIM3_Ana_Laura_Moyano.DAL.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.BLL
{
    public class XmlBLL
    {
        public string RutaArchivo { get; set; }

        public XmlBLL(string rutaArchivo)
        {
            RutaArchivo = rutaArchivo;
        }

        public void GuardarXml<T>(T entidad)
        {
            using (FileStream fileStream = new FileStream(RutaArchivo, FileMode.Create))
            {
                IXml xml = new XmlHelper();
                string xmlData = xml.Serialize(entidad);

                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(xmlData);
                writer.Close();
            }
        }

        public T LeerXml<T>()
        {
            using (FileStream fileStream = new FileStream(RutaArchivo, FileMode.Open))
            {
                IXml xml = new XmlHelper();
                StreamReader reader = new StreamReader(fileStream);
                string data = reader.ReadToEnd();
                reader.Close();
                return xml.Deserialize<T>(data);
            }
        }
    }
}
