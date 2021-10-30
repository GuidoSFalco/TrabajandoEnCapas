using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datos
{
    public class DatosConexionBD
    {
        public OleDbConnection conexion;
        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Documents\Bases de datos\basededatos11.accdb";
        public DatosConexionBD()
        { 
        conexion = new OleDbConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
            if (conexion.State == ConnectionState.Broken || conexion.State ==
            ConnectionState.Closed)
                conexion.Open();
            }
            catch (Exception e)
            {
            throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
        try
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
        catch (Exception e)
        {
            throw new Exception("Error al tratar de cerrar la conexión", e);
        }
        }


        public void SaveAlumno(string nom, string dni, DateTime fech, int edad, char sex, string leg, string car)
        {
            Abrirconexion();
            OleDbCommand guardar = new OleDbCommand("insert into Alumnos values(@Nombre,@Dni,@Fecha,@Edad,@Sexo,@Legajo,@Carrera)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Nombre", nom);
                guardar.Parameters.AddWithValue("@Dni", dni);
                guardar.Parameters.AddWithValue("@Fecha", fech);
                guardar.Parameters.AddWithValue("@Edad", edad);
                guardar.Parameters.AddWithValue("@Sexo", Convert.ToChar(sex));
                guardar.Parameters.AddWithValue("@Legajo", leg);
                guardar.Parameters.AddWithValue("@Carrera", car);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {
                
                MessageBox.Show(ez.Message);
            }
            finally
            {
                Cerrarconexion();
            }
        }

        public void SaveDocente(string nom, string dni, DateTime fech, int edad, string sex, string leg, string mat)
        {
            Abrirconexion();
            OleDbCommand guardar = new OleDbCommand("insert into Docente values(@Nombre,@Curso,@Materia)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Nombre", nom);
                guardar.Parameters.AddWithValue("@Dni", dni);
                guardar.Parameters.AddWithValue("@Fecha", fech);
                guardar.Parameters.AddWithValue("@Edad", edad);
                guardar.Parameters.AddWithValue("@Sexo", Convert.ToChar(sex));
                guardar.Parameters.AddWithValue("@Legajo", leg);
                guardar.Parameters.AddWithValue("@Materia", mat);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
            finally
            {
                Cerrarconexion();
            }
        }

        public void Delete(string dni, DataGridView dgv, string cadenaA, string cadenaB)
        {
            Abrirconexion();

            if (cadenaA == "delete from Alumnos where Dni = (@Dni)")
            {
                OleDbCommand Borrar = new OleDbCommand(cadenaA, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                OleDbCommand Borrar = new OleDbCommand(cadenaB, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }
    }
}
