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
    public partial class FormAdmDocente : Form
    {
        public FormAdmDocente()
        {
            InitializeComponent();
        }

        int posicion = 0;

        Docente docente = new Docente();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text =="" || txtMateria.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error");
            }
            else
            {
            posicion = datagridview.Rows.Add();

            docente.Curso = Convert.ToString( txtCurso.Text);
            docente.Materia = Convert.ToString(txtMateria.Text);
            docente.Nombre = Convert.ToString(txtNombre.Text);

            datagridview.Rows[posicion].Cells[0].Value = txtNombre.Text;
            datagridview.Rows[posicion].Cells[1].Value = txtMateria.Text;
            datagridview.Rows[posicion].Cells[2].Value = txtCurso.Text;

            }



            
            
        }

        private void btnFormAlumnos_Click(object sender, EventArgs e)
        {
            Form form = new FormAdmAlumnos();
            form.Show();
        }

        private void btnProfesionales_Click(object sender, EventArgs e)
        {
            Form form = new FormAdmProfes();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            posicion = datagridview.CurrentRow.Index;
            datagridview.Rows.RemoveAt(posicion);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtNombre.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtMateria.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }

        private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtCurso.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }
    }
}
