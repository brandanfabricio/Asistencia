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
    public class Dpersona
    {

        public DataTable Listar(int escuela)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection Sqlcon = new SqlConnection();

            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("listar_persona", Sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@escuela", SqlDbType.Int).Value = escuela;

                Sqlcon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;

            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                    Sqlcon.Close();
            }
        }

        public string Insertar(Eperosona obj)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("agregar_persona", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = obj.apellido;
                comando.Parameters.Add("@curso", SqlDbType.Int).Value = obj.id_curso;
                sqlcon.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo realizare el registro";
            }
            catch (Exception ex) {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return respuesta;


        }

        public string Actualizar(Eperosona Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("actualizar_persona", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id", SqlDbType.Int).Value = Obj.id_persona;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = Obj.apellido;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
           
        }






    }

}
