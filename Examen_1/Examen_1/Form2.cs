using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        List<decimal> listaProductos = new List<decimal>();
        double Total = 0;
  
        public void AgregarProducto()
        {       
            string NombreProducto = Convert.ToString(ProductoTextBox.Text);
            double PrecioProducto = Convert.ToDouble(PrecioTextBox.Text);
            listaProductos.Add((decimal)PrecioProducto);

                Total = Total + PrecioProducto;
                listaProductos.Add((decimal)Total);

            ProductosListBox.Items.Add(NombreProducto+": ");
            ProductosListBox.Items.Add(PrecioProducto);
            ProductosListBox.Items.Add("");
            ProductoTextBox.Text = "";
            PrecioTextBox.Text = "";
        }


        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        double Descuento = 0;
        double Subtotal = 0;

        public void CalcularTotal()
        {
            Subtotal = Total;
            Descuento = Total * 0.15;
            Total = Total - Descuento;

            ProductosListBox.Items.Add("Subtotal:  "+Subtotal);
            ProductosListBox.Items.Add("Descuento: "+Descuento);
            ProductosListBox.Items.Add("Total:     "+Total);
        }

        private void CalcularTotalButton_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
