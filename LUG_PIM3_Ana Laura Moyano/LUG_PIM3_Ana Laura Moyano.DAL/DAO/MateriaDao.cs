using LUG_PIM3_Ana_Laura_Moyano.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUG_PIM3_Ana_Laura_Moyano.DAL.DAO
{
    public class MateriaDao : IDao<Materia>
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        public MateriaDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private void Abrir()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void Cerrar()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
            sqlConnection = null;
            GC.Collect();
        }

        public void Actualizar(Materia entidad)
        {
            Abrir();
            SqlCommand sqlCommand = new SqlCommand("EliminarMateria", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = CrearMateriaDatatable(entidad);

            sqlCommand.Parameters.AddWithValue("@materia", dataTable);
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public IEnumerable<Materia> Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Materia entidad)
        {
            Abrir();
            SqlCommand sqlCommand = new SqlCommand("EliminarMateria", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = CrearMateriaDatatable(entidad);
            dataTable.AcceptChanges();

            sqlCommand.Parameters.AddWithValue("@materia", dataTable);
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public void Guardar(Materia entidad)
        {
            Abrir();
            SqlCommand sqlCommand = new SqlCommand("InsertarMateria", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = CrearMateriaDatatable(entidad);

            sqlCommand.Parameters.AddWithValue("@materia", dataTable);
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        private static DataTable CrearMateriaDatatable(Materia entidad)
        {
            DataTable dataTable = new DataTable("Materias");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("codigo");
            dataTable.Columns.Add("descripcion");

            DataRow row = dataTable.NewRow();

            row["id"] = entidad.Id;
            row["codigo"] = entidad.Codigo;
            row["descripcion"] = entidad.Descripcion;

            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();

            return dataTable;
        }

        public IEnumerable<Materia> ListarTodo()
        {
            List<Materia> resultado = new List<Materia>();
            DataSet dataSet = new DataSet();

            Abrir();
            string query = "SELECT * FROM Materias";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(dataSet, "Materias");
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                resultado.Add(MapearMateria(row));
            }
            Cerrar();

            return resultado;
        }

        private Materia MapearMateria(DataRow row)
        {
            return new Materia
            {
                Id = (int)row["id"],
                Codigo = (string)row["codigo"],
                Descripcion = (string)row["descripcion"]
            };
        }
    }
}
