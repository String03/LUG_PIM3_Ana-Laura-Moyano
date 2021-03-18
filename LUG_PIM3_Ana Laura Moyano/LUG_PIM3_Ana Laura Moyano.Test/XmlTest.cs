using System;
using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.DAL.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LUG_PIM3_Ana_Laura_Moyano.Test
{
    [TestClass]
    public class XmlTest
    {
        [TestMethod]
        public void TestSerializar()
        {
            IXml xml = new XmlHelper();
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Ayumi",
                Apellido = "Fernandez Moyano",
                Celular = "809-983-6123",
                Direccion = "Por ahi",
                Email = "afernandez@porahi.com",
                FechaNacimiento = DateTime.Now,
                FechaReg = DateTime.Now,
                Legajo = "AYY LEGAJO",
                Telefono = "809-534-9652"
            };
            string resultado = xml.Serialize(estudiante);
        }

        [TestMethod]
        public void TestSerializar2()
        {
            IXml xml = new XmlHelper();
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Ayumi",
                Apellido = "Fernandez Moyano",
                Celular = "809-983-6123",
                Direccion = "Por ahi",
                Email = "afernandez@porahi.com",
                FechaNacimiento = DateTime.Now,
                FechaReg = DateTime.Now,
                Legajo = "AYY LEGAJO",
                Telefono = "809-534-9652"
            };
            XmlViewModel viewModel = new XmlViewModel
            {
                Estudiantes = new System.Collections.Generic.List<Estudiante>()
            };
            viewModel.Estudiantes.Add(estudiante);
            string resultado = xml.Serialize(viewModel);
        }

        [TestMethod]
        public void TestDeserializar()
        {
            string data = "<?xml version=\"1.0\"?>\r\n<Estudiante xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Id>1</Id>\r\n  <Legajo>AYY LEGAJO</Legajo>\r\n  <Nombre>Ayumi</Nombre>\r\n  <Apellido>Fernandez Moyano</Apellido>\r\n  <Telefono>809-534-9652</Telefono>\r\n  <Celular>809-983-6123</Celular>\r\n  <Email>afernandez@porahi.com</Email>\r\n  <Direccion>Por ahi</Direccion>\r\n  <FechaNacimiento>2019-07-13T17:49:40.7915036-04:00</FechaNacimiento>\r\n  <FechaReg>2019-07-13T17:49:40.7915036-04:00</FechaReg>\r\n  <Materias />\r\n</Estudiante>";
            IXml xml = new XmlHelper();
            Estudiante estudiante = xml.Deserialize<Estudiante>(data);
            Assert.AreEqual(estudiante.Nombre, "Ayumi");
        }

        [TestMethod]
        public void TestDeserializar2()
        {
            string data = "<?xml version=\"1.0\"?>\r\n<XmlViewModel xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Estudiantes>\r\n    <Estudiante>\r\n      <Id>1</Id>\r\n      <Legajo>AYY LEGAJO</Legajo>\r\n      <Nombre>Ayumi</Nombre>\r\n      <Apellido>Fernandez Moyano</Apellido>\r\n      <Telefono>809-534-9652</Telefono>\r\n      <Celular>809-983-6123</Celular>\r\n      <Email>afernandez@porahi.com</Email>\r\n      <Direccion>Por ahi</Direccion>\r\n      <FechaNacimiento>2019-07-16T00:01:41.8770663-04:00</FechaNacimiento>\r\n      <FechaReg>2019-07-16T00:01:41.8770663-04:00</FechaReg>\r\n      <Materias />\r\n    </Estudiante>\r\n  </Estudiantes>\r\n</XmlViewModel>";
            IXml xml = new XmlHelper();
            XmlViewModel viewModel = xml.Deserialize<XmlViewModel>(data);
        }
    }
}
