using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Integrador
{
    public partial class FormAdmProfes : Form
    {
        public FormAdmProfes()
        {
            InitializeComponent();
            //dgvProfesionales.ColumnCount = 2;
            //dgvProfesionales.Columns[0].HeaderText = "Código";
            //dgvProfesionales.Columns[1].HeaderText = "Nombre";
            //dgvProfesionales.Columns[0].Width = 60;
            //dgvProfesionales.Columns[1].Width = 200;



        }

        public Profesional objEntProf = new Profesional();

        public NegProfesionales objNegProf = new NegProfesionales();


        private void LlenarDGV()
        {
            dgvProfesionales.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProf.listadoProfesionales("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),
                    //etc..dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                lblMensaje.Text = "No hay profesionales cargados en el sistema";
        }

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            try
            {
                objEntProf.CodProf = int.Parse(txtCodigo.Text);
                objEntProf.Nombre = txtNombre.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Error","Error");
            }
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a la capa de negocio
            if (nGrabados == -1)
                lblMensaje.Text = " No pudo grabar profesionales en el sistema";
            else
            {
                lblMensaje.Text = " Se grabó con éxito profesionales.";
                LlenarDGV();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }


        private void dgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntProf.CodProf = Convert.ToInt32(dgvProfesionales.CurrentRow.Cells[0].Value);
            ds = objNegProf.listadoProfesionales(objEntProf.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnGrabar.Visible = false;
                lblMensaje.Text = string.Empty;
            }
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtCodigo.Enabled = false;
        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_Obj();
            nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invoco a la capa de negocio
            if (nResultado != -1)
            {
                MessageBox.Show("Aviso", "El Profesional fue Modificado con éxito");
                Limpiar();
                LlenarDGV();

                txtCodigo.Enabled = true;

            }
            else
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el Profesional");
}

        private void btnFormAlumnos_Click(object sender, EventArgs e)
        {
            Form form = new FormAdmAlumnos();
            form.Show();
        }

        private void btnFormDocentes_Click(object sender, EventArgs e)
        {
            Form form = new FormAdmDocente();
            form.Show();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) 
            {
                txtCodigo.Text = "";
                MessageBox.Show("Solo numeros", "Error");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                txtNombre.Text = "";
                MessageBox.Show("No se permiten numeros", "Error");
            }
        }
    }
}
