using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente
    {
        private string materia;
        private string curso;
        private string nombre;
        public string Materia
        {
            get => materia;
            set => materia = value;
        }
        public string Curso
        {
            get => curso;
            set => curso = value;
        }
        public string Nombre 
        { get => nombre; 
          set => nombre = value; 
        }
    }
}
