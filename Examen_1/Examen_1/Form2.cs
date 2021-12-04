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
 
        double Total = 0;

        public string TotalPagar { get; private set; }

        public async Task<double> CalcularTotalAsync()
        {
            
            Descuento = Total * 0.15;

            double TotalPagar = await Task.Run(() =>
            { 
                  return Total - Descuento;
                });
            return TotalPagar;
        }

        public void Mostrar()
        {
            ProductosListBox.Items.Add("Subtotal:  " + Total);
            ProductosListBox.Items.Add("Descuento: " + Descuento);
            ProductosListBox.Items.Add("Total:     " + (Total-Descuento));

         }

        private void CalcularTotalButton_Click(object sender, EventArgs e)
        {
            Task<double> task = CalcularTotalAsync();
            Mostrar();
        }
    }
}
