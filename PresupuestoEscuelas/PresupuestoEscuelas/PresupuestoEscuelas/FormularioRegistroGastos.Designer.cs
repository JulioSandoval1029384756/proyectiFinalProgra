namespace PresupuestoEscuelas
{
    partial class FormularioRegistroGastos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button buttonGuardarGasto;

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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.buttonGuardarGasto = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 13);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripción:";
           
            this.textBoxDescripcion.Location = new System.Drawing.Point(101, 13);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(259, 22);
            this.textBoxDescripcion.TabIndex = 1;
          
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(13, 42);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(50, 17);
            this.labelMonto.TabIndex = 2;
            this.labelMonto.Text = "Monto:";
           
            this.textBoxMonto.Location = new System.Drawing.Point(101, 42);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(259, 22);
            this.textBoxMonto.TabIndex = 3;
           
            this.buttonGuardarGasto.Location = new System.Drawing.Point(285, 71);
            this.buttonGuardarGasto.Name = "buttonGuardarGasto";
            this.buttonGuardarGasto.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarGasto.TabIndex = 4;
            this.buttonGuardarGasto.Text = "Guardar";
            this.buttonGuardarGasto.UseVisualStyleBackColor = true;
            this.buttonGuardarGasto.Click += new System.EventHandler(this.buttonGuardarGasto_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.buttonGuardarGasto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Name = "FormularioRegistroGastos";
            this.Text = "Registro de Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}