using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string carrera;
        private long legajo;
        #region Propiedades
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public long Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion
        #region Constructores

        public Alumno(string Nom, long Du, DateTime FecNac, char Sex, string Carr, long
        Leg)
        {
            Carrera = Carr;
            Legajo = Leg;
        }
        #endregion
    }
}
