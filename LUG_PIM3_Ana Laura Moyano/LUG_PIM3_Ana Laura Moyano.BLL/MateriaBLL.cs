using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.BLL
{
    public class MateriaBLL
    {
        private IDao<Materia> materiaDao;

        public MateriaBLL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;
            materiaDao = new MateriaDao(connectionString);
        }

        public void GuardarMateria(Materia materia)
        {
            try
            {
                materiaDao.Guardar(materia);
            }
            catch (SqlException)
            {
                throw new Exception("Ha ocurrido un error de base de datos, por favor verifique los datos");
            }
            catch (Exception ex)
            {
                throw new Exception("Error creando la materia.");
            }
        }

        public void ActualizarMateria(Materia materia)
        {
            try
            {
                materiaDao.Actualizar(materia);
            }
            catch (SqlException)
            {
                throw new Exception("Ha ocurrido un error de base de datos, por favor verifique los datos");
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error actualizando la materia.");
            }
        }

        public void EliminarMateria(Materia materia)
        {
            try
            {
                materiaDao.Eliminar(materia);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    throw new Exception("Este registro de materia esta en uso.");
                throw new Exception("Ha ocurrido un error de base de datos, por favor verifique los datos");
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error eliminando la materia.");
            }
        }

        public IEnumerable<Materia> ListarMaterias()
        {
            return materiaDao.ListarTodo();
        }
    }
}
