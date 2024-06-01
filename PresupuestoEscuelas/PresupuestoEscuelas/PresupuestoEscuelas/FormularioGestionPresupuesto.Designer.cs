using System;
using System.Windows.Forms;

namespace PresupuestoEscuelas
{
    partial class FormularioGestionPresupuesto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.TextBox textBoxMontoAsignado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonAsignarPresupuesto;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.Label labelMontoAsignado;
        private System.Windows.Forms.Label labelFecha;

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
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.textBoxMontoAsignado = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonAsignarPresupuesto = new System.Windows.Forms.Button();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.labelMontoAsignado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Location = new System.Drawing.Point(160, 37);
            this.textBoxMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.Size = new System.Drawing.Size(265, 22);
            this.textBoxMontoTotal.TabIndex = 0;
            // 
            // textBoxMontoAsignado
            // 
            this.textBoxMontoAsignado.Location = new System.Drawing.Point(160, 86);
            this.textBoxMontoAsignado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMontoAsignado.Name = "textBoxMontoAsignado";
            this.textBoxMontoAsignado.Size = new System.Drawing.Size(265, 22);
            this.textBoxMontoAsignado.TabIndex = 1;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFecha.Location = new System.Drawing.Point(160, 135);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFecha.TabIndex = 2;
            // 
            // buttonAsignarPresupuesto
            // 
            this.buttonAsignarPresupuesto.Location = new System.Drawing.Point(160, 185);
            this.buttonAsignarPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAsignarPresupuesto.Name = "buttonAsignarPresupuesto";
            this.buttonAsignarPresupuesto.Size = new System.Drawing.Size(267, 28);
            this.buttonAsignarPresupuesto.TabIndex = 3;
            this.buttonAsignarPresupuesto.Text = "Asignar Presupuesto";
            this.buttonAsignarPresupuesto.UseVisualStyleBackColor = true;
            this.buttonAsignarPresupuesto.Click += new System.EventHandler(this.buttonAsignarPresupuesto_Click);
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Location = new System.Drawing.Point(27, 37);
            this.labelMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(81, 16);
            this.labelMontoTotal.TabIndex = 4;
            this.labelMontoTotal.Text = "Monto Total:";
            this.labelMontoTotal.Click += new System.EventHandler(this.labelMontoTotal_Click);
            // 
            // labelMontoAsignado
            // 
            this.labelMontoAsignado.AutoSize = true;
            this.labelMontoAsignado.Location = new System.Drawing.Point(27, 86);
            this.labelMontoAsignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMontoAsignado.Name = "labelMontoAsignado";
            this.labelMontoAsignado.Size = new System.Drawing.Size(108, 16);
            this.labelMontoAsignado.TabIndex = 5;
            this.labelMontoAsignado.Text = "Monto Asignado:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(27, 135);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(48, 16);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha:";
            // 
            // FormularioGestionPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 246);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelMontoAsignado);
            this.Controls.Add(this.labelMontoTotal);
            this.Controls.Add(this.buttonAsignarPresupuesto);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxMontoAsignado);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioGestionPresupuesto";
            this.Text = "Gestionar Presupuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAsignarPresupuesto_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException
            // AsignarPresupuesto
            string montoTotal = textBoxMontoTotal.Text;
            string montoAsignado = textBoxMontoAsignado.Text;
            string fecha = "02/03/2024";// dateTimePickerFecha.Text;
            int numeroAlumnos = 0;

            if ( !string.IsNullOrEmpty(montoTotal) && !string.IsNullOrEmpty(montoAsignado))
            {

                GestionPresupuesto gestion = new GestionPresupuesto("Server=DESKTOP-HB9L7EH\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Proyecto");
                Presupuesto presupuesto = new Presupuesto(0, decimal.Parse(montoTotal), decimal.Parse(montoAsignado), DateTime.Now);
                gestion.AsignarPresupuesto(presupuesto);
                //CargarEscuelas();
                MessageBox.Show("presupuesto asignado .");
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente.");
            }
        }
    }
}