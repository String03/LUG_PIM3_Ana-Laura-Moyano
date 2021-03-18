using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.DAL.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.Test
{
    [TestClass]
    public class ADOTest
    {
        [TestMethod]
        public void ConectadoTest()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
        }

        [TestMethod]
        public void EstudianteSelectTest()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            IDao<Estudiante> estudianteDao = new EstudianteDao(connectionString);
            var estudiantes = estudianteDao.ListarTodo();
            Assert.IsTrue(estudiantes.Count() > 0);
        }

        [TestMethod]
        public void EstudianteSelectWhereTest()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            IDao<Estudiante> estudianteDao = new EstudianteDao(connectionString);
            Estudiante estudiante = estudianteDao.Buscar(1).FirstOrDefault();
            Assert.IsNotNull(estudiante);
        }

        [TestMethod]
        public void EstudianteInsertTest()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            IDao<Estudiante> estudianteDao = new EstudianteDao(connectionString);
            estudianteDao.Guardar(new Estudiante
            {
                Nombre = "Adelina",
                Apellido = "fernandez",
                Legajo = "4321",
                FechaNacimiento = DateTime.Now,
                Direccion = "por ahi",
                Email = "adelina@email.com",
                Celular = "8099836123",
                FechaReg = DateTime.Now
            });
        }

        [TestMethod]
        public void DesconectadoTest()
        {
        }

        [TestMethod]
        public void InsertarDataRow()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            IDao<Materia> dao = new MateriaDao(connectionString);
            var materia = new Materia
            {
                Codigo = "A",
                Descripcion = "Ayy no se"
            };
            dao.Guardar(materia);
        }
    }
}
