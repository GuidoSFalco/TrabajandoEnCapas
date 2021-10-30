using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegDocentes
    {
        DatosDocentes ObjDatosDocente = new DatosDocentes();

        public int abmDocentes(string accion, Docente ObjDocente)
        {
            return ObjDatosDocente.abmDocentes(accion, ObjDocente);
        }
        public DataSet listadoDocentes(string todo)
        {
            return ObjDatosDocente.listadoDocentes(todo);
        }

    }
}
