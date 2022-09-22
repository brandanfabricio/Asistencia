using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asistente.Entidad;
using Asistente.Dato;
using System.Data;

namespace Asistente.negocio
{
    public class Ncurso
    {
        public static DataTable Listar(int escuela)
        {

            Dcurso Datos = new Dcurso();
            return Datos.Listar(escuela);

        }
        public static string Insertar(string curso ,int escueal)
        {
            Dcurso Dato = new Dcurso();
            Ecurso obj = new Ecurso();
            obj.curso = curso;
            obj.id_escuela = escueal;
            return Dato.Insertar(obj);

        }


    }
}