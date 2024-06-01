namespace PresupuestoEscuelas
{
    partial class FormularioGestionEscuelas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxNombreEscuela;
        private System.Windows.Forms.Button buttonRegistrarEscuela;
        private System.Windows.Forms.ListBox listBoxEscuelas;
        private System.Windows.Forms.Label labelNombreEscuela;
        private System.Windows.Forms.TextBox textBoxNombreAlumno;
        private System.Windows.Forms.Button buttonRegistrarAlumno;
        private System.Windows.Forms.Label labelNombreAlumno;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxNombreEscuela = new System.Windows.Forms.TextBox();
            this.buttonRegistrarEscuela = new System.Windows.Forms.Button();
            this.listBoxEscuelas = new System.Windows.Forms.ListBox();
            this.labelNombreEscuela = new System.Windows.Forms.Label();
            this.textBoxNombreAlumno = new System.Windows.Forms.TextBox();
            this.buttonRegistrarAlumno = new System.Windows.Forms.Button();
            this.labelNombreAlumno = new System.Windows.Forms.Label();
            this.SuspendLayout();

            
            this.textBoxNombreEscuela.Location = new System.Drawing.Point(120, 30);
            this.textBoxNombreEscuela.Name = "textBoxNombreEscuela";
            this.textBoxNombreEscuela.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreEscuela.TabIndex = 0;
            
            this.buttonRegistrarEscuela.Location = new System.Drawing.Point(120, 70);
            this.buttonRegistrarEscuela.Name = "buttonRegistrarEscuela";
            this.buttonRegistrarEscuela.Size = new System.Drawing.Size(200, 23);
            this.buttonRegistrarEscuela.TabIndex = 1;
            this.buttonRegistrarEscuela.Text = "Registrar Escuela";
            this.buttonRegistrarEscuela.UseVisualStyleBackColor = true;
            this.buttonRegistrarEscuela.Click += new System.EventHandler(this.buttonRegistrarEscuela_Click);
           
            this.listBoxEscuelas.FormattingEnabled = true;
            this.listBoxEscuelas.Location = new System.Drawing.Point(20, 110);
            this.listBoxEscuelas.Name = "listBoxEscuelas";
            this.listBoxEscuelas.Size = new System.Drawing.Size(300, 160);
            this.listBoxEscuelas.TabIndex = 2;
           
            this.labelNombreEscuela.AutoSize = true;
            this.labelNombreEscuela.Location = new System.Drawing.Point(20, 30);
            this.labelNombreEscuela.Name = "labelNombreEscuela";
            this.labelNombreEscuela.Size = new System.Drawing.Size(93, 13);
            this.labelNombreEscuela.TabIndex = 3;
            this.labelNombreEscuela.Text = "Nombre de Escuela:";
           
            this.textBoxNombreAlumno.Location = new System.Drawing.Point(120, 290);
            this.textBoxNombreAlumno.Name = "textBoxNombreAlumno";
            this.textBoxNombreAlumno.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreAlumno.TabIndex = 4;
            
            this.buttonRegistrarAlumno.Location = new System.Drawing.Point(120, 330);
            this.buttonRegistrarAlumno.Name = "buttonRegistrarAlumno";
            this.buttonRegistrarAlumno.Size = new System.Drawing.Size(200, 23);
            this.buttonRegistrarAlumno.TabIndex = 5;
            this.buttonRegistrarAlumno.Text = "Registrar Alumno";
            this.buttonRegistrarAlumno.UseVisualStyleBackColor = true;
            this.buttonRegistrarAlumno.Click += new System.EventHandler(this.buttonRegistrarAlumno_Click);
         
            this.labelNombreAlumno.AutoSize = true;
            this.labelNombreAlumno.Location = new System.Drawing.Point(20, 290);
            this.labelNombreAlumno.Name = "labelNombreAlumno";
            this.labelNombreAlumno.Size = new System.Drawing.Size(90, 13);
            this.labelNombreAlumno.TabIndex = 6;
            this.labelNombreAlumno.Text = "Nombre de Alumno:";
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 370);
            this.Controls.Add(this.labelNombreAlumno);
            this.Controls.Add(this.buttonRegistrarAlumno);
            this.Controls.Add(this.textBoxNombreAlumno);
            this.Controls.Add(this.labelNombreEscuela);
            this.Controls.Add(this.listBoxEscuelas);
            this.Controls.Add(this.buttonRegistrarEscuela);
            this.Controls.Add(this.textBoxNombreEscuela);
            this.Name = "FormularioGestionEscuelas";
            this.Text = "Gestionar Escuelas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}