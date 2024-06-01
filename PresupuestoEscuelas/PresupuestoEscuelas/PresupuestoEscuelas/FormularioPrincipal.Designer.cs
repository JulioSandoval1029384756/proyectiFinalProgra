namespace PresupuestoEscuelas
{
    partial class FormularioPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Button buttonGestionarPresupuesto;
        private System.Windows.Forms.Button buttonRegistrarGasto;
        private System.Windows.Forms.Button buttonGestionEscuelas;
        private System.Windows.Forms.Button buttonRegistroAlimentos;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.buttonGestionarPresupuesto = new System.Windows.Forms.Button();
            this.buttonRegistrarGasto = new System.Windows.Forms.Button();
            this.buttonGestionEscuelas = new System.Windows.Forms.Button();
            this.buttonRegistroAlimentos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.BackColor = System.Drawing.Color.Black;
            this.labelBienvenida.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelBienvenida.Location = new System.Drawing.Point(419, 23);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(174, 32);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "¡Bienvenido!";
            this.labelBienvenida.Click += new System.EventHandler(this.labelBienvenida_Click);
            // 
            // buttonGestionarPresupuesto
            // 
            this.buttonGestionarPresupuesto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGestionarPresupuesto.FlatAppearance.BorderSize = 0;
            this.buttonGestionarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarPresupuesto.ForeColor = System.Drawing.Color.Gray;
            this.buttonGestionarPresupuesto.Location = new System.Drawing.Point(401, 108);
            this.buttonGestionarPresupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionarPresupuesto.Name = "buttonGestionarPresupuesto";
            this.buttonGestionarPresupuesto.Size = new System.Drawing.Size(213, 45);
            this.buttonGestionarPresupuesto.TabIndex = 1;
            this.buttonGestionarPresupuesto.Text = "Gestionar Presupuesto";
            this.buttonGestionarPresupuesto.UseVisualStyleBackColor = false;
            this.buttonGestionarPresupuesto.Click += new System.EventHandler(this.buttonGestionarPresupuesto_Click);
            // 
            // buttonRegistrarGasto
            // 
            this.buttonRegistrarGasto.BackColor = System.Drawing.Color.Black;
            this.buttonRegistrarGasto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarGasto.ForeColor = System.Drawing.Color.DimGray;
            this.buttonRegistrarGasto.Location = new System.Drawing.Point(401, 338);
            this.buttonRegistrarGasto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrarGasto.Name = "buttonRegistrarGasto";
            this.buttonRegistrarGasto.Size = new System.Drawing.Size(213, 45);
            this.buttonRegistrarGasto.TabIndex = 2;
            this.buttonRegistrarGasto.Text = "Registrar Gasto";
            this.buttonRegistrarGasto.UseVisualStyleBackColor = false;
            this.buttonRegistrarGasto.Click += new System.EventHandler(this.buttonRegistrarGasto_Click);
            // 
            // buttonGestionEscuelas
            // 
            this.buttonGestionEscuelas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGestionEscuelas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionEscuelas.ForeColor = System.Drawing.Color.DimGray;
            this.buttonGestionEscuelas.Location = new System.Drawing.Point(401, 186);
            this.buttonGestionEscuelas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionEscuelas.Name = "buttonGestionEscuelas";
            this.buttonGestionEscuelas.Size = new System.Drawing.Size(213, 45);
            this.buttonGestionEscuelas.TabIndex = 3;
            this.buttonGestionEscuelas.Text = "Gestionar Escuelas";
            this.buttonGestionEscuelas.UseVisualStyleBackColor = false;
            this.buttonGestionEscuelas.Click += new System.EventHandler(this.buttonGestionEscuelas_Click);
            // 
            // buttonRegistroAlimentos
            // 
            this.buttonRegistroAlimentos.BackColor = System.Drawing.Color.Black;
            this.buttonRegistroAlimentos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroAlimentos.ForeColor = System.Drawing.Color.DimGray;
            this.buttonRegistroAlimentos.Location = new System.Drawing.Point(401, 262);
            this.buttonRegistroAlimentos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistroAlimentos.Name = "buttonRegistroAlimentos";
            this.buttonRegistroAlimentos.Size = new System.Drawing.Size(213, 45);
            this.buttonRegistroAlimentos.TabIndex = 4;
            this.buttonRegistroAlimentos.Text = "Registrar Alimentos";
            this.buttonRegistroAlimentos.UseVisualStyleBackColor = false;
            this.buttonRegistroAlimentos.Click += new System.EventHandler(this.buttonRegistroAlimentos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 498);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonRegistrarGasto);
            this.Controls.Add(this.buttonGestionarPresupuesto);
            this.Controls.Add(this.buttonRegistroAlimentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGestionEscuelas);
            this.Controls.Add(this.labelBienvenida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}