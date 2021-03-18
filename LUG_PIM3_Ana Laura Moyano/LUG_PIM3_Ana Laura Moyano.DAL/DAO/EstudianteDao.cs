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
    public class EstudianteDao : IDao<Estudiante>
    {
        private string connectionString;

        private SqlConnection sqlConnection;

        public EstudianteDao(string connectionString)
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

        public void Actualizar(Estudiante entidad)
        {
            Abrir();
            string query = "UPDATE Estudiantes SET legajo = @legajo, nombres = @nombres, apellido = @apellido, telefono = @telefono, celular = @celular, email = @email, direccion = @direccion, fecha_nacimiento = @fecha_nacimiento WHERE ID = @id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = entidad.Id;
            sqlCommand.Parameters.Add("@legajo", SqlDbType.VarChar).Value = entidad.Legajo;
            sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar).Value = entidad.Nombre;
            sqlCommand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = (object)entidad.Apellido ?? DBNull.Value;
            sqlCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = (object)entidad.Telefono ?? DBNull.Value;
            sqlCommand.Parameters.Add("@celular", SqlDbType.VarChar).Value = (object)entidad.Celular ?? DBNull.Value;
            sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = entidad.Email;
            sqlCommand.Parameters.Add("@direccion", SqlDbType.VarChar).Value = entidad.Direccion;
            sqlCommand.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = entidad.FechaNacimiento;
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public IEnumerable<Estudiante> Buscar(int id)
        {
            Abrir();
            string query = "SELECT * FROM Estudiantes WHERE ID = @id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            ICollection<Estudiante> estudiantes = new List<Estudiante>();
            if (reader.HasRows)
            {
                while (reader.Read())
                    estudiantes.Add(MapearEstudiante(reader));
            }
            Cerrar();
            return estudiantes;
        }

        public void Eliminar(Estudiante entidad)
        {
            Abrir();
            string query = "DELETE FROM Estudiantes WHERE ID = @id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", DbType.Int32).Value = entidad.Id;
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public void Guardar(Estudiante entidad)
        {
            Abrir();
            string query = "INSERT INTO Estudiantes(legajo, nombres, apellido, telefono, celular, email, direccion, fecha_nacimiento, fecha_reg) VALUES(@legajo, @nombres, @apellido, @telefono, @celular,@email, @direccion, @fecha_nacimiento, @fecha_reg)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@legajo", SqlDbType.VarChar).Value = entidad.Legajo;
            sqlCommand.Parameters.Add("@nombres", SqlDbType.VarChar).Value = entidad.Nombre;
            sqlCommand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = (object)entidad.Apellido ?? DBNull.Value;
            sqlCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = (object)entidad.Telefono ?? DBNull.Value;
            sqlCommand.Parameters.Add("@celular", SqlDbType.VarChar).Value = (object)entidad.Celular ?? DBNull.Value;
            sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = entidad.Email;
            sqlCommand.Parameters.Add("@direccion", SqlDbType.VarChar).Value = entidad.Direccion;
            sqlCommand.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = entidad.FechaNacimiento;
            sqlCommand.Parameters.Add("@fecha_reg", SqlDbType.DateTime).Value = entidad.FechaReg == default(DateTime) ? DateTime.Now : entidad.FechaReg;
            sqlCommand.ExecuteNonQuery();
            Cerrar();
        }

        public IEnumerable<Estudiante> ListarTodo()
        {
            Abrir();
            string query = "SELECT * FROM Estudiantes";
            List<Estudiante> resultado = new List<Estudiante>();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                resultado.Add(MapearEstudiante(reader));
            }

            reader.Close();

            Cerrar();
            return resultado;
        }

        private Estudiante MapearEstudiante(IDataRecord dataRecord)
        {
            return new Estudiante
            {
                Id = (int)dataRecord["id"],
                Nombre = dataRecord["nombres"].ToString(),
                Apellido = dataRecord["apellido"] as string,
                Telefono = dataRecord["telefono"] as string,
                Celular = dataRecord["celular"] as string,
                Direccion = dataRecord["direccion"] as string,
                Email = dataRecord["email"] as string,
                FechaNacimiento = (DateTime)dataRecord["fecha_nacimiento"],
                FechaReg = (DateTime)dataRecord["fecha_reg"],
                Legajo = dataRecord["legajo"] as string
            };
        }
    }
}
