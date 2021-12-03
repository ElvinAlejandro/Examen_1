
namespace Examen_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalarioActualTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevoSalarioTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.CalcularSueldoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaNacTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AntiguedadTextBox = new System.Windows.Forms.TextBox();
            this.VentasPromTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalarioActualTextBox
            // 
            this.SalarioActualTextBox.Location = new System.Drawing.Point(253, 48);
            this.SalarioActualTextBox.Name = "SalarioActualTextBox";
            this.SalarioActualTextBox.Size = new System.Drawing.Size(200, 20);
            this.SalarioActualTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Salario Actual";
            // 
            // NuevoSalarioTextBox
            // 
            this.NuevoSalarioTextBox.Enabled = false;
            this.NuevoSalarioTextBox.Location = new System.Drawing.Point(213, 292);
            this.NuevoSalarioTextBox.Name = "NuevoSalarioTextBox";
            this.NuevoSalarioTextBox.ReadOnly = true;
            this.NuevoSalarioTextBox.Size = new System.Drawing.Size(142, 20);
            this.NuevoSalarioTextBox.TabIndex = 25;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(527, 192);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 24;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // CalcularSueldoButton
            // 
            this.CalcularSueldoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularSueldoButton.Location = new System.Drawing.Point(527, 97);
            this.CalcularSueldoButton.Name = "CalcularSueldoButton";
            this.CalcularSueldoButton.Size = new System.Drawing.Size(75, 64);
            this.CalcularSueldoButton.TabIndex = 23;
            this.CalcularSueldoButton.Text = "Calcular Sueldo";
            this.CalcularSueldoButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "NUEVO SALARIO";
            // 
            // FechaNacTimePicker
            // 
            this.FechaNacTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacTimePicker.Location = new System.Drawing.Point(253, 96);
            this.FechaNacTimePicker.Name = "FechaNacTimePicker";
            this.FechaNacTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaNacTimePicker.TabIndex = 21;
            // 
            // AntiguedadTextBox
            // 
            this.AntiguedadTextBox.Location = new System.Drawing.Point(253, 192);
            this.AntiguedadTextBox.Name = "AntiguedadTextBox";
            this.AntiguedadTextBox.Size = new System.Drawing.Size(200, 20);
            this.AntiguedadTextBox.TabIndex = 20;
            // 
            // VentasPromTextBox
            // 
            this.VentasPromTextBox.Location = new System.Drawing.Point(253, 140);
            this.VentasPromTextBox.Name = "VentasPromTextBox";
            this.VentasPromTextBox.Size = new System.Drawing.Size(200, 20);
            this.VentasPromTextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Años de Antiguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ventas Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 366);
            this.Controls.Add(this.SalarioActualTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoSalarioTextBox);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularSueldoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaNacTimePicker);
            this.Controls.Add(this.AntiguedadTextBox);
            this.Controls.Add(this.VentasPromTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Formulario 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalarioActualTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NuevoSalarioTextBox;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button CalcularSueldoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaNacTimePicker;
        private System.Windows.Forms.TextBox AntiguedadTextBox;
        private System.Windows.Forms.TextBox VentasPromTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

