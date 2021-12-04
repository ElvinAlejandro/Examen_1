
namespace Examen_1
{
    partial class Form2
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
            this.CalcularTotalButton = new System.Windows.Forms.Button();
            this.ProductosListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarProductoButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcularTotalButton
            // 
            this.CalcularTotalButton.Location = new System.Drawing.Point(242, 347);
            this.CalcularTotalButton.Name = "CalcularTotalButton";
            this.CalcularTotalButton.Size = new System.Drawing.Size(124, 37);
            this.CalcularTotalButton.TabIndex = 8;
            this.CalcularTotalButton.Text = "Calcular";
            this.CalcularTotalButton.UseVisualStyleBackColor = true;
            this.CalcularTotalButton.Click += new System.EventHandler(this.CalcularTotalButton_Click);
            // 
            // ProductosListBox
            // 
            this.ProductosListBox.FormattingEnabled = true;
            this.ProductosListBox.Location = new System.Drawing.Point(388, 81);
            this.ProductosListBox.Name = "ProductosListBox";
            this.ProductosListBox.Size = new System.Drawing.Size(398, 303);
            this.ProductosListBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PrecioTextBox);
            this.groupBox2.Controls.Add(this.ProductoTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 205);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar Datos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "L. 200,000.00";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(105, 97);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(230, 20);
            this.PrecioTextBox.TabIndex = 4;
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(105, 56);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(230, 20);
            this.ProductoTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(6, 137);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 16);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Depósito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prducto";
            // 
            // AgregarProductoButton
            // 
            this.AgregarProductoButton.Location = new System.Drawing.Point(242, 277);
            this.AgregarProductoButton.Name = "AgregarProductoButton";
            this.AgregarProductoButton.Size = new System.Drawing.Size(124, 37);
            this.AgregarProductoButton.TabIndex = 9;
            this.AgregarProductoButton.Text = "Agregar Producto";
            this.AgregarProductoButton.UseVisualStyleBackColor = true;
            this.AgregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgregarProductoButton);
            this.Controls.Add(this.CalcularTotalButton);
            this.Controls.Add(this.ProductosListBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcularTotalButton;
        private System.Windows.Forms.ListBox ProductosListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarProductoButton;
    }
}