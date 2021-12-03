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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {
            CalcularInteres();
        }

        List<decimal> listaIntereses = new List<decimal>();

        public void CalcularInteres()
        {
            decimal Interes = 0;
            decimal i = 0.015M;
            decimal Capital = 200000M;
            int Tiempo = 30;

            for (int j = 0; j < 12; j++)
            {
                Capital = Capital + Interes;
                Interes = (Capital * i * Tiempo) / 360;

                //listaIntereses.Add(Capital);

                InteresesListBox.Items.Add("Capital Actual: " + Capital..ToString("N") + " Interés Ganado mes de " + Interes);
                j++;
            }



        }

        private void CalcularInteresButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
