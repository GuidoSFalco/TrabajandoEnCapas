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




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "" || txtDNI.Text == "" || txtCarrera.Text == "" || txtLegajo.Text == "")
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



                int a = dataGridView1.Rows.Add();

                dataGridView1.Rows[a].Cells[0].Value = alumnos.Nombre;
                dataGridView1.Rows[a].Cells[1].Value = alumnos.Dni;
                dataGridView1.Rows[a].Cells[2].Value = alumnos.Carrera;
                dataGridView1.Rows[a].Cells[3].Value = alumnos.Legajo;
                dataGridView1.Rows[a].Cells[4].Value = alumnos.Nacimiento;

                if (radioButton1.Checked == true)
                {
                    dataGridView1.Rows[a].Cells[5].Value = "Masculino";
                }

                if (radioButton2.Checked == true)
                {
                    dataGridView1.Rows[a].Cells[5].Value = "Femenino";

                }

                if (radioButton3.Checked == true)
                {
                    dataGridView1.Rows[a].Cells[5].Value = "Otro";
                }

            }
                

            
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
            posicion = dataGridView1.CurrentRow.Index;

            txtNombre.Text = dataGridView1[0, posicion].Value.ToString();
            txtDNI.Text = dataGridView1[1, posicion].Value.ToString();
            txtLegajo.Text = dataGridView1[2, posicion].Value.ToString();
            txtCarrera.Text = dataGridView1[3, posicion].Value.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Error en los datos", "Error", MessageBoxButtons.OK);
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
            posicion = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(posicion);
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
                txtNombre.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtDNI.Text = "";
                MessageBox.Show("Solo numeros", "Error");
            }
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtLegajo.Text = "";
                MessageBox.Show("Solo numeros", "Error");
            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtCarrera.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }
    }
}
