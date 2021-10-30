
namespace Integrador
{
    partial class FormAdmDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormAlumnos = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btAddD = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnProfesionales = new System.Windows.Forms.Button();
            this.btBorrarD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCarreraA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormAlumnos
            // 
            this.btnFormAlumnos.Location = new System.Drawing.Point(15, 15);
            this.btnFormAlumnos.Name = "btnFormAlumnos";
            this.btnFormAlumnos.Size = new System.Drawing.Size(109, 23);
            this.btnFormAlumnos.TabIndex = 17;
            this.btnFormAlumnos.Text = "Formulario Alumnos";
            this.btnFormAlumnos.UseVisualStyleBackColor = true;
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(216, 173);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(75, 23);
            this.btMod.TabIndex = 16;
            this.btMod.Text = "Modificar";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click_1);
            // 
            // btAddD
            // 
            this.btAddD.Location = new System.Drawing.Point(135, 173);
            this.btAddD.Name = "btAddD";
            this.btAddD.Size = new System.Drawing.Size(75, 23);
            this.btAddD.TabIndex = 15;
            this.btAddD.Text = "Grabar";
            this.btAddD.UseVisualStyleBackColor = true;
            this.btAddD.Click += new System.EventHandler(this.btAddD_Click_1);
            // 
            // datagridview
            // 
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(391, 61);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(397, 269);
            this.datagridview.TabIndex = 14;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(74, 237);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Materia";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(216, 121);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 10;
            // 
            // btnProfesionales
            // 
            this.btnProfesionales.Location = new System.Drawing.Point(130, 15);
            this.btnProfesionales.Name = "btnProfesionales";
            this.btnProfesionales.Size = new System.Drawing.Size(134, 23);
            this.btnProfesionales.TabIndex = 18;
            this.btnProfesionales.Text = "Formulario Profesionales";
            this.btnProfesionales.UseVisualStyleBackColor = true;
            // 
            // btBorrarD
            // 
            this.btBorrarD.Location = new System.Drawing.Point(297, 173);
            this.btBorrarD.Name = "btBorrarD";
            this.btBorrarD.Size = new System.Drawing.Size(75, 23);
            this.btBorrarD.TabIndex = 19;
            this.btBorrarD.Text = "Eliminar";
            this.btBorrarD.UseVisualStyleBackColor = true;
            this.btBorrarD.Click += new System.EventHandler(this.btBorrarD_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // cbCarreraA
            // 
            this.cbCarreraA.FormattingEnabled = true;
            this.cbCarreraA.Items.AddRange(new object[] {
            "Programacion",
            "Matematica",
            "Fisica"});
            this.cbCarreraA.Location = new System.Drawing.Point(216, 94);
            this.cbCarreraA.Name = "cbCarreraA";
            this.cbCarreraA.Size = new System.Drawing.Size(100, 21);
            this.cbCarreraA.TabIndex = 53;
            // 
            // FormAdmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCarreraA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btBorrarD);
            this.Controls.Add(this.btnProfesionales);
            this.Controls.Add(this.btnFormAlumnos);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.btAddD);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Name = "FormAdmDocente";
            this.Text = "FormAdmDocente";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormAlumnos;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btAddD;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnProfesionales;
        private System.Windows.Forms.Button btBorrarD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbCarreraA;
    }
}