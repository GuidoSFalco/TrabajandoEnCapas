using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Integrador
{
    public partial class FormAdmAlumnos : Form
    {
        public FormAdmAlumnos()
        {
            InitializeComponent();
        }
        public Alumno alumnos = new Alumno();
        int posicion = 0;
        string genero;

        
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                if (radioButton1.Checked == true)
                {
                genero = "Masculino";
                alumnos.Sexo = "Masculino";
                }

                if (radioButton2.Checked == true)
                {
                genero = "Femenino";
                alumnos.Sexo = "Femenino";

                }

                if (radioButton3.Checked == true)
                {
                genero = "Otro";
                alumnos.Sexo = "Otro";
                }

            if (txtNombre.Text == "" || txtDNI.Text == "" || txtCarrera.Text == "" || txtLegajo.Text == "" || txtLegajo.Text == "" || genero == null)
            {
                MessageBox.Show("Hay campos vacios", "Error");
            }
            else
            {
                alumnos.Nombre = Convert.ToString(txtNombre.Text);
                alumnos.Dni = Convert.ToInt32(txtDNI.Text);
                alumnos.Carrera = txtCarrera.Text;
                alumnos.Legajo = Convert.ToInt32(txtLegajo.Text);
                alumnos.Nacimiento = Convert.ToDateTime(dateTimer.Value.ToShortDateString());
                alumnos.Sexo = genero;




                int b = dataGridView1.Rows.Add();

                dataGridView1.Rows[b].Cells[0].Value = alumnos.Nombre;
                dataGridView1.Rows[b].Cells[1].Value = alumnos.Dni;
                dataGridView1.Rows[b].Cells[2].Value = alumnos.Carrera;
                dataGridView1.Rows[b].Cells[3].Value = alumnos.Legajo;
                dataGridView1.Rows[b].Cells[4].Value = alumnos.Nacimiento;
                dataGridView1.Rows[b].Cells[5].Value = alumnos.Sexo;

                //string orden = string.Empty;
                //orden = "Insert into Alumnos values (@Nombre, @Dni,@Fecha,@Edad,@Sexo,@Legajo,@Carrera);";
                //OleDbCommand cmd = new OleDbCommand(orden, conexion);
                //try
                //{
                /*
                    Abrirconexion();
                    cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objAlumno.FechNac.Date);
                    cmd.Parameters.AddWithValue("@Edad", objAlumno.Edad(edad));
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
                    CerrarConexion();
                    cmd.Dispose();
                }
                */


                /*
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Documents\Bases de datos\basededatos11.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Alumnos", con);
                
                orden = "insert into Alumnos values (" + alumnos.Nombre + ",'" + alumnos.Dni + "';"+alumnos.Legajo+";"+alumnos.Carrera+";"+alumnos.Nacimiento+";"+alumnos.Sexo+");";

                OleDbDataAdapter sda = new OleDbDataAdapter();
                DataTable td = new DataTable();
                sda.SelectCommand = cmd;
                sda.Fill(td);
                dataGridView1.DataSource = td;

                con.Close();
                */
            }

            
            
            
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount == 1 || dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay datos registrados para modificar", "Error");
            }
            else
            {
            posicion = dataGridView1.CurrentRow.Index;

            txtNombre.Text = dataGridView1[0, posicion].Value.ToString();
            txtDNI.Text = dataGridView1[1, posicion].Value.ToString();
            txtLegajo.Text = dataGridView1[2, posicion].Value.ToString();
            txtCarrera.Text = dataGridView1[3, posicion].Value.ToString();
            }
            
        }

        


private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            posicion = dataGridView1.CurrentRow.Index;
            

            dataGridView1[0, posicion].Value = txtNombre.Text;
            dataGridView1[1, posicion].Value = txtDNI.Text;
            dataGridView1[2, posicion].Value = txtLegajo.Text;
            dataGridView1[3, posicion].Value = txtCarrera.Text;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 1 || dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay datos registrados","Error");
            }
            else
            {

            posicion = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(posicion);
            }
        }

        private void btnFormDocentes_Click(object sender, EventArgs e)
        {
            Form form = new FormAdmDocente();
            form.Show();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
                return;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Error");
                e.Handled = true;
                return;
            }
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Error");
                e.Handled = true;
                return;
            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
                return;
            }
        }

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Documents\Bases de datos\basededatos11.accdb");
        private void FormAdmAlumnos_Load(object sender, EventArgs e)
        {
            
            

            //OleDbDataAdapter sda = new OleDbDataAdapter();
            //DataTable td = new DataTable();
            //sda.SelectCommand = cmd;
            //sda.Fill(td);
            //dataGridView1.DataSource = td;
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //string orden = "Insert into Alumnos(Nombre, DNI, Legajo, Carrera, Nacimiento, Genero) values (,@dni,@legajo,@carrera,@nacimiento,@genero)";
            //con.Open();
            //OleDbCommand cmd = new OleDbCommand(orden, con);
            //cmd.Parameters.AddWithValue("@nombre", alumnos.Nombre);
            //cmd.Parameters.AddWithValue("@dni", alumnos.Dni);
            //cmd.Parameters.AddWithValue("@legajo", alumnos.Legajo);
            //cmd.Parameters.AddWithValue("@carrera", alumnos.Carrera);
            //cmd.Parameters.AddWithValue("@nacimiento", alumnos.Nacimiento);
            //cmd.Parameters.AddWithValue("@genero", genero);
        }
    }
}
