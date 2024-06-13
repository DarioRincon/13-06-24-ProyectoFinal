namespace ProyectoFinal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerarResultado;
        private System.Windows.Forms.Button btnMostrarHistorial;
        private System.Windows.Forms.Button btnBorrarHistorial;
        private System.Windows.Forms.ListBox lstHistorial;

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
            this.btnGenerarResultado = new System.Windows.Forms.Button();
            this.btnMostrarHistorial = new System.Windows.Forms.Button();
            this.btnBorrarHistorial = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarResultado
            // 
            this.btnGenerarResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarResultado.Location = new System.Drawing.Point(12, 199);
            this.btnGenerarResultado.Name = "btnGenerarResultado";
            this.btnGenerarResultado.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarResultado.TabIndex = 0;
            this.btnGenerarResultado.Text = "Generar Resultado";
            this.btnGenerarResultado.UseVisualStyleBackColor = false;
            this.btnGenerarResultado.Click += new System.EventHandler(this.btnGenerarResultado_Click);
            // 
            // btnMostrarHistorial
            // 
            this.btnMostrarHistorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMostrarHistorial.Location = new System.Drawing.Point(168, 199);
            this.btnMostrarHistorial.Name = "btnMostrarHistorial";
            this.btnMostrarHistorial.Size = new System.Drawing.Size(150, 23);
            this.btnMostrarHistorial.TabIndex = 1;
            this.btnMostrarHistorial.Text = "Mostrar Historial";
            this.btnMostrarHistorial.UseVisualStyleBackColor = false;
            this.btnMostrarHistorial.Click += new System.EventHandler(this.btnMostrarHistorial_Click);
            // 
            // btnBorrarHistorial
            // 
            this.btnBorrarHistorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrarHistorial.Location = new System.Drawing.Point(86, 228);
            this.btnBorrarHistorial.Name = "btnBorrarHistorial";
            this.btnBorrarHistorial.Size = new System.Drawing.Size(150, 23);
            this.btnBorrarHistorial.TabIndex = 2;
            this.btnBorrarHistorial.Text = "Borrar Historial";
            this.btnBorrarHistorial.UseVisualStyleBackColor = false;
            this.btnBorrarHistorial.Click += new System.EventHandler(this.btnBorrarHistorial_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(12, 33);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(306, 160);
            this.lstHistorial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KickLogicStats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(330, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.btnBorrarHistorial);
            this.Controls.Add(this.btnMostrarHistorial);
            this.Controls.Add(this.btnGenerarResultado);
            this.Name = "Form1";
            this.Text = "Resultados de Partidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
