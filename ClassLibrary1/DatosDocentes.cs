using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Datos
{
    public class DatosDocentes : DatosConexionBD
    {
        public int abmDocentes(string accion, Docente objDocente)
        {
            int a=0;
            a = a+1;
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "Insert into Docente values (@Nombre, @Curso,@Materia);";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {

                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objDocente.Nombre);
                    cmd.Parameters.AddWithValue("@Materia", objDocente.Materia);
                    cmd.Parameters.AddWithValue("@Curso", objDocente.Curso);

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
                orden = "delete from Docente where Nombre ='" +objDocente.Nombre.ToString() + "';";
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

                orden = "Update Docente set Materia=@Materia, Curso=@Curso, where Nombre = @Nombre";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                try
                {
                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objDocente.Nombre);
                    cmd.Parameters.AddWithValue("@Materia", objDocente.Materia);
                    cmd.Parameters.AddWithValue("@Curso", objDocente.Curso);

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

        public DataSet listadoDocentes(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Docente;";
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

                throw new Exception("Error al listar Docentes", e);
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
