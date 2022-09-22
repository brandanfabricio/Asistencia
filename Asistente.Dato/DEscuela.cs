using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Asistente.Entidad;
using System.Data.SqlClient;

namespace Asistente.Dato
{
    public class DEscuela
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("listar_escuela", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
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

        public string Insertar(EtiEscueal obj)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("agreagar_escuela", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Escuela", SqlDbType.VarChar).Value = obj.escuela;
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
