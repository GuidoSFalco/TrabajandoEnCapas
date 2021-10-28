using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string nombre;
        private long dni;
        private DateTime nacimiento;
        private string sexo;

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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }

        }

        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }

        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }
        #endregion
        #region Constructores

        /*public Alumno(string Nom, long Du, DateTime FecNac, char Sex, string Carr, long
        Leg)
        {
            Nombre = Nom;
            Dni = Du;
            Nacimiento = FecNac;
            Sexo = Sex;
            Carrera = Carr;
            Legajo = Leg;
        }
        */
        #endregion
    }
}
