using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Asistente.Dato;
using Asistente.Entidad;

namespace Asistente.negocio
{
    public class NEscuela
    {
        public static DataTable Listar()
        {
            DEscuela Datos = new DEscuela();

            
            return Datos.Listar();

        }
        public static string Insertar(string escuela)
        {
            DEscuela Dato = new DEscuela();
            EtiEscueal obj = new EtiEscueal();
            obj.escuela = escuela;
            return Dato.Insertar(obj);



        }

    }
}
