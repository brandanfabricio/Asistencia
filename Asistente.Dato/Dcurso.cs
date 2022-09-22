using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Asistente.Entidad;

namespace Asistente.Dato
{
    public class Dcurso
    {

        public DataTable Listar(int escuela)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("listar_curso", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@escuela", SqlDbType.Int).Value = escuela;

                Sqlcon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                    Sqlcon.Close();
            }
        }

        public string Insertar(Ecurso obj)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("agregar_curso", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@curso", SqlDbType.VarChar).Value = obj.curso;
                comando.Parameters.Add("@Escuela", SqlDbType.Int).Value = obj.id_escuela;
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo realizare el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return respuesta;

        }
    }
}
