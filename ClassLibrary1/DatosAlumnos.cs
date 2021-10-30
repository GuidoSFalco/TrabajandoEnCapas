using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Entidades;
using System.Windows.Forms;
using System.Data;

namespace Datos
{
    class DatosAlumnos : DatosConexionBD
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            int edad = objAlumno.Nacimiento.Year;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "Insert into Alumnos values (@Nombre, @Dni,@Fecha,@Sexo,@Legajo,@Carrera);";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {

                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objAlumno.Nacimiento.Date);
                    cmd.Parameters.AddWithValue("@Sexo", objAlumno.Sexo);
                    cmd.Parameters.AddWithValue("@Legajo", objAlumno.Legajo);
                    cmd.Parameters.AddWithValue("@Carrera", objAlumno.Carrera);
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("El Dni ingresado ya existe en la tabla", "Error");
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Baja")
            {
                orden = "delete from Alumnos where Dni ='" + objAlumno.Dni.ToString() + "';";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Modificar")
            {

                orden = "Update Alumnos set Nombre = @Nombre, [Fecha-de-nacimiento] = @Fecha, Sexo= @Sexo, Legajo= @Legajo, Carrera=@Carrera where Dni = @Dni";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objAlumno.Nacimiento.Date);
                    cmd.Parameters.AddWithValue("@Sexo", objAlumno.Sexo);
                    cmd.Parameters.AddWithValue("@Legajo", objAlumno.Legajo);
                    cmd.Parameters.AddWithValue("@Carrera", objAlumno.Carrera);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
            }


            return resultado;
        }

        public DataSet listadoAlumnos(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Alumnos;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Alumnos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}

