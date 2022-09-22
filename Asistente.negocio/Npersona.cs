using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asistente.Dato;
using System.Data;
using Asistente.Entidad;

namespace Asistente.negocio
{
    public class Npersona
    {
        public static DataTable Listar(int escuela)
        {
            Dpersona Datos = new Dpersona();
            
            return Datos.Listar(escuela);

        }


        public static string Insertar(string nombre,string apellido,int IdEscuela)
        {
            Dpersona Dato = new Dpersona();
            Eperosona obj = new Eperosona();

            obj.nombre = nombre;
            obj.apellido = apellido;
            obj.id_curso = IdEscuela;
            return Dato.Insertar(obj);
        }


        public static string Actualizar(int Id, string Nombre, string Apellido)
        {
            Dpersona Datos = new Dpersona();
            Eperosona Obj = new Eperosona();

                Obj.id_persona = Id;
                Obj.nombre= Nombre;
                Obj.apellido = Apellido;
                return Datos.Actualizar(Obj);


        }
    }
}
