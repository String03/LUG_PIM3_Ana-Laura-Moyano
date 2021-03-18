using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.DAL.DAO;
using LUG_PIM3_Ana_Laura_Moyano.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.BLL
{
    public class EstudianteBLL
    {
        IDao<Estudiante> estudianteDao;
        IDao<MateriaPorEstudiante> materiaEstudianteDao;

        public EstudianteBLL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            estudianteDao = new EstudianteDao(connectionString);
            materiaEstudianteDao = new MateriaPorEstudianteDao(connectionString);
        }

        public IEnumerable<Estudiante> ListarEstudiantes()
        {
            var estudiantes = estudianteDao.ListarTodo();
            foreach (var estudiante in estudiantes)
                estudiante.Materias.AddRange(materiaEstudianteDao.Buscar(estudiante.Id));
            return estudiantes;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                if (!ValidarCorreo(estudiante.Email))
                {
                    throw new InvalidOperationException("Correo no valido");
                }
                if (!ValidarFechaNacimiento(estudiante.FechaNacimiento))
                {
                    throw new InvalidOperationException("La edad debe ser mayor a 2");
                }
                var listado = estudianteDao.ListarTodo();
                if (listado.Any(e => e.Legajo == estudiante.Legajo))
                    throw new Exception("Ya existe un estudiante con este legajo.");
                estudianteDao.Guardar(estudiante);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw new Exception("Ha ocurrido un error insertando los datos del estudiante, por favor confirmar datos.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error creando el estudiante.");
            }
        }

        private bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            return ((DateTime.Now - fechaNacimiento).TotalDays / 365.0) >= 2.0;
        }

        private bool ValidarCorreo(string email)
        {
            if (string.IsNullOrEmpty(email))
                return true;
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
            return regex.IsMatch(email);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            try
            {
                estudianteDao.Eliminar(estudiante);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    throw new Exception("Este estudiante se encuentra estudiando una materia.");
                throw new Exception("Ha ocurrido un error insertando los datos del estudiante, por favor confirmar datos.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error eliminando estudiante");
            }
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            try
            {
                if (!ValidarCorreo(estudiante.Email))
                {
                    throw new InvalidOperationException("Correo no valido");
                }
                if (!ValidarFechaNacimiento(estudiante.FechaNacimiento))
                {
                    throw new InvalidOperationException("La edad debe ser mayor a 2");
                }
                estudianteDao.Actualizar(estudiante);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw new Exception("Ha ocurrido un error de base de datos, por favor verifique sus datos.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando el estudiante.");
            }
        }

        public string GenerarXmlMaterias(Estudiante estudiante)
        {
            IXml xml = new XmlHelper();
            return xml.Serialize(estudiante.Materias);
        }

        public void AsociarEstudianteMateria(Estudiante estudiante, Materia materia)
        {
            try
            {
                if (estudiante == null || materia == null)
                    throw new InvalidOperationException("Datos nulos");

                if (estudiante.Materias.Where(m => m.Calificacion == null).Any(m => m.MateriaId == materia.Id))
                    throw new InvalidOperationException("El estudiante se encuentra cursando esta materia");
                if (estudiante.Materias.Where(m => m.Calificacion >= 4).Any(m => m.MateriaId == materia.Id))
                    throw new InvalidOperationException("Es estudiante ya aprobo esta materia");

                MateriaPorEstudiante materiaPorEstudiante = new MateriaPorEstudiante
                {
                    MateriaId = materia.Id,
                    EstudianteId = estudiante.Id,
                    Calificacion = null
                };
                materiaEstudianteDao.Guardar(materiaPorEstudiante);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("Error asociando estudiante y materia");
            }
        }

        public void CalificarMateria(MateriaPorEstudiante materiaPorEstudiante, int calificacion)
        {
            try
            {
                if (materiaPorEstudiante == null || calificacion == 0)
                    throw new InvalidOperationException("Datos no validos para la operacion");

                if (materiaPorEstudiante.Calificacion != null)
                    throw new InvalidOperationException("Esta materia ya esta calificada.");

                materiaPorEstudiante.Calificacion = calificacion;

                materiaEstudianteDao.Actualizar(materiaPorEstudiante);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarMateriaAsociada(MateriaPorEstudiante materiaPorEstudiante)
        {
            try
            {
                if (materiaPorEstudiante.Calificacion != null)
                    throw new InvalidOperationException("Esta materia ya fue calificada.");
                materiaEstudianteDao.Eliminar(materiaPorEstudiante);
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
