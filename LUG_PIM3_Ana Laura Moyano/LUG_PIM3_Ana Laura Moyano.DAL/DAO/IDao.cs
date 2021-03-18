using System.Collections.Generic;

namespace LUG_PIM3_Ana_Laura_Moyano.DAL.DAO
{
    public interface IDao<T>
    {
        IEnumerable<T> ListarTodo();
        IEnumerable<T> Buscar(int id);
        void Guardar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
    }
}
