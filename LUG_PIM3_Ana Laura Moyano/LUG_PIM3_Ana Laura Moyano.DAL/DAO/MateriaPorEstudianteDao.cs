using LUG_PIM3_Ana_Laura_Moyano.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LUG_PIM3_Ana_Laura_Moyano.DAL.DAO
{
    public class MateriaPorEstudianteDao : IDao<MateriaPorEstudiante>
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        public MateriaPorEstudianteDao(string connectionString)
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

        public void Actualizar(MateriaPorEstudiante entidad)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction trx = con.BeginTransaction();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("ActualizarMateriasPorEstudiante", sqlConnection, trx);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Transaction = trx;
                    sqlCommand.Connection = con;
                    DataTable dataTable = CrearMateriaPorEstudianteDatatable(entidad);
                    sqlCommand.Parameters.AddWithValue("@materiaEstudiante", dataTable);

                    sqlCommand.ExecuteNonQuery();

                    trx.Commit();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    throw ex;
                }
            }
        }

        public IEnumerable<MateriaPorEstudiante> Buscar(int id)
        {
            List<MateriaPorEstudiante> resultado = new List<MateriaPorEstudiante>();
            DataSet dataSet = new DataSet();

            Abrir();
            string query = "SELECT * FROM MateriasPorEstudiante WHERE estudiante_id = " + id;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(dataSet, "MateriasPorEstudiante");
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                resultado.Add(MapearMateria(row));
            }
            Cerrar();
            return resultado;
        }

        public void Eliminar(MateriaPorEstudiante entidad)
        {
            Abrir();
            SqlCommand sqlCommand = new SqlCommand("EliminarMateriaPorEstudiante", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = CrearMateriaPorEstudianteDatatable(entidad);
            dataTable.AcceptChanges();

            sqlCommand.Parameters.AddWithValue("@materiaEstudiante", dataTable);
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public void Guardar(MateriaPorEstudiante entidad)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction trx = con.BeginTransaction();
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("InsertarMateriasPorEstudiante", sqlConnection, trx);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Transaction = trx;
                    sqlCommand.Connection = con;
                    DataTable dataTable = CrearMateriaPorEstudianteDatatable(entidad);
                    sqlCommand.Parameters.AddWithValue("@materiaEstudiante", dataTable);

                    sqlCommand.ExecuteNonQuery();

                    trx.Commit();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    throw ex;
                }
            }
        }

        private static DataTable CrearMateriaPorEstudianteDatatable(MateriaPorEstudiante entidad)
        {
            DataTable dataTable = new DataTable("Materias");
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("estudiante_id");
            dataTable.Columns.Add("materia_id");
            dataTable.Columns.Add("calificacion");

            DataRow row = dataTable.NewRow();

            row["id"] = entidad.Id;
            row["estudiante_id"] = entidad.EstudianteId;
            row["materia_id"] = entidad.MateriaId;
            row["calificacion"] = entidad.Calificacion;

            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();

            return dataTable;
        }

        public IEnumerable<MateriaPorEstudiante> ListarTodo()
        {
            List<MateriaPorEstudiante> resultado = new List<MateriaPorEstudiante>();
            DataSet dataSet = new DataSet();

            Abrir();
            string query = "SELECT * FROM MateriasPorEstudiante";
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

        private MateriaPorEstudiante MapearMateria(DataRow row)
        {
            return new MateriaPorEstudiante
            {
                Id = (int)row["id"],
                EstudianteId = (int)row["estudiante_id"],
                MateriaId = (int)row["materia_id"],
                Calificacion = row["calificacion"] == DBNull.Value ? null : (int?)row["calificacion"]
            };
        }
    }
}
