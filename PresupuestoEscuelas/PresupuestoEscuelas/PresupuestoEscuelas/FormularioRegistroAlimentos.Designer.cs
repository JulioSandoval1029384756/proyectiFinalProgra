namespace PresupuestoEscuelas
{
    partial class FormularioRegistroAlimentos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNombreAlimento;
        private System.Windows.Forms.TextBox textBoxNombreAlimento;
        private System.Windows.Forms.Label labelPrecioAlimento;
        private System.Windows.Forms.TextBox textBoxPrecioAlimento;
        private System.Windows.Forms.Button buttonGuardarAlimento;

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
            this.labelNombreAlimento = new System.Windows.Forms.Label();
            this.textBoxNombreAlimento = new System.Windows.Forms.TextBox();
            this.labelPrecioAlimento = new System.Windows.Forms.Label();
            this.textBoxPrecioAlimento = new System.Windows.Forms.TextBox();
            this.buttonGuardarAlimento = new System.Windows.Forms.Button();
            this.SuspendLayout();

           
            this.labelNombreAlimento.AutoSize = true;
            this.labelNombreAlimento.Location = new System.Drawing.Point(20, 20);
            this.labelNombreAlimento.Name = "labelNombreAlimento";
            this.labelNombreAlimento.Size = new System.Drawing.Size(99, 13);
            this.labelNombreAlimento.TabIndex = 0;
            this.labelNombreAlimento.Text = "Nombre del Alimento:";
           
            this.textBoxNombreAlimento.Location = new System.Drawing.Point(130, 20);
            this.textBoxNombreAlimento.Name = "textBoxNombreAlimento";
            this.textBoxNombreAlimento.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreAlimento.TabIndex = 1;
             
            this.labelPrecioAlimento.AutoSize = true;
            this.labelPrecioAlimento.Location = new System.Drawing.Point(20, 60);
            this.labelPrecioAlimento.Name = "labelPrecioAlimento";
            this.labelPrecioAlimento.Size = new System.Drawing.Size(84, 13);
            this.labelPrecioAlimento.TabIndex = 2;
            this.labelPrecioAlimento.Text = "Precio del Alimento:";
           
            this.textBoxPrecioAlimento.Location = new System.Drawing.Point(130, 60);
            this.textBoxPrecioAlimento.Name = "textBoxPrecioAlimento";
            this.textBoxPrecioAlimento.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrecioAlimento.TabIndex = 3;
          
            this.buttonGuardarAlimento.Location = new System.Drawing.Point(130, 100);
            this.buttonGuardarAlimento.Name = "buttonGuardarAlimento";
            this.buttonGuardarAlimento.Size = new System.Drawing.Size(200, 23);
            this.buttonGuardarAlimento.TabIndex = 4;
            this.buttonGuardarAlimento.Text = "Guardar Alimento";
            this.buttonGuardarAlimento.UseVisualStyleBackColor = true;
            this.buttonGuardarAlimento.Click += new System.EventHandler(this.buttonGuardarAlimento_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.buttonGuardarAlimento);
            this.Controls.Add(this.textBoxPrecioAlimento);
            this.Controls.Add(this.labelPrecioAlimento);
            this.Controls.Add(this.textBoxNombreAlimento);
            this.Controls.Add(this.labelNombreAlimento);
            this.Name = "FormularioRegistroAlimentos";
            this.Text = "Registrar Alimento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}