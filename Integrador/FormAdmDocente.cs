using Entidades;
using Negocios;
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
            datagridview.ColumnCount = 7;
            datagridview.Columns[0].HeaderText = "Nombre";
            datagridview.Columns[1].HeaderText = "Dni";
            datagridview.Columns[2].HeaderText = "Fecha de nacimiento";
            datagridview.Columns[3].HeaderText = "Edad";
            datagridview.Columns[4].HeaderText = "Sexo";
            datagridview.Columns[6].HeaderText = "Legajo";
            datagridview.Columns[5].HeaderText = "Materia";


            datagridview.Columns[0].Width = 200;
            datagridview.Columns[1].Width = 60;
            datagridview.Columns[2].Width = 75;
            datagridview.Columns[3].Width = 40;
            datagridview.Columns[4].Width = 65;
            datagridview.Columns[5].Width = 80;
            datagridview.Columns[6].Width = 200;

            


            FillDGV();
        }
        /*
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
            if (datagridview.RowCount == 1)
            {
                lblMensaje.Text = "No hay datos registrados";
            }
            else
            {

                posicion = datagridview.CurrentRow.Index;
                datagridview.Rows.RemoveAt(posicion);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtNombre.Text = "";
                lblMensaje.Text = "No se permiten numeros";
            }
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtMateria.Text = "";
                lblMensaje.Text = "No se permiten numeros";
            }
        }

        private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtCurso.Text = "";
                lblMensaje.Text = "No se permiten numeros";
            }
        }
        */





        public Docente ObjEntDocente = new Docente();
        public NegDocentes ObjNegDocentes = new NegDocentes();


        #region Constructor

        

        #endregion

        #region Eventos

        
        private void DGVdocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pos = datagridview.CurrentRow.Index;
                if (datagridview[1, pos].Value == null)
                {
                    MessageBox.Show("La fila debe contener datos", "Error");
                }
                else
                {

                    txtNombre.Text = datagridview[0, pos].Value.ToString();
                    txtMateria.Text = datagridview[1, pos].Value.ToString();
                    txtMateria.Text = datagridview[2, pos].Value.ToString();

                    

                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

        }


        private void Limpiar()
        {
            txtNombre.Clear();
            txtMateria.Clear();
            txtCurso.Clear();

        }


        private void FillDGV()
        {
            datagridview.Rows.Clear();
            DataSet ds = new DataSet();
            ds = ObjNegDocentes.listadoDocentes("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    
                    datagridview.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                }
                lblMensaje.Text = "";
            }
            else
            {
                lblMensaje.Text = "No hay docentes cargados en el sistema";
            }
        }

        private void TxtObj()
        {
            ObjEntDocente.Nombre = txtNombre.Text;
            ObjEntDocente.Materia = txtMateria.Text;
            ObjEntDocente.Curso = txtCurso.Text;
        }

        private void DGVaObj()
        {
            int pos = datagridview.CurrentRow.Index;
            ObjEntDocente.Nombre = (datagridview[0, pos].Value.ToString());

        }

        private void txtLegajoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
        }

        private void txtDniD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
           
        }
        private void txtNombreD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
            
        }
        private void cbMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No se permiten numeros", "Error");
                e.Handled = true;
            }
        #endregion
        }

        private void btAddD_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMateria.Text == "" || txtCurso.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un docente", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = ObjNegDocentes.abmDocentes("Alta", ObjEntDocente);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo grabar el docente en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }


                Limpiar();
            }
        }

        private void btMod_Click_1(object sender, EventArgs e)
        {
            if (ObjEntDocente.Nombre == "")
            {
                MessageBox.Show("Debe completar todos los campos para poder agregar un alumno", "Error");
            }
            else
            {
                int nAdd = -1;
                TxtObj();

                nAdd = ObjNegDocentes.abmDocentes("Modificar", ObjEntDocente);
                if (nAdd == -1)
                {
                    MessageBox.Show("No pudo modificar el docente en el sistema");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }

            }
        }

        private void btBorrarD_Click_1(object sender, EventArgs e)
        {
            if (datagridview.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {
                int nDel = -1;
                DGVaObj();
                nDel = ObjNegDocentes.abmDocentes("Baja", ObjEntDocente);
                if (nDel == -1)
                {
                    MessageBox.Show("No se pudo borrar", "Error");
                }
                else
                {
                    FillDGV();
                    Limpiar();
                }
            }
        }
    }
}