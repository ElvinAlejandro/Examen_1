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
  

        List<decimal> listaIntereses = new List<decimal>();

        public void CalcularInteres()
        {
            decimal Interes = 0;
            decimal i = 0.015M;
            decimal Capital = 200000M;
            int Tiempo = 12;
            string Mes = "";

            for (int j = 1; j < 12; j++)
            {
                Capital = Capital + Interes;
                Interes = Capital * i * Tiempo;

                listaIntereses.Add(Capital);

                switch (j)
                {
                    case 1:
                        Mes = "Enero";
                        break;
                    case 2:
                        Mes = "Febrero";
                        break;
                    case 3:
                        Mes = "";
                        break;
                    case 4:
                        Mes = "";
                        break;
                    case 5:
                        Mes = "";
                        break;
                    case 6:
                        Mes = "";
                        break;
                    case 7:
                        Mes = "";
                        break;
                    case 8:
                        Mes = "";
                        break;
                    case 9:
                        Mes = "";
                        break;
                    case 10:
                        Mes = "";
                        break;
                    case 11:
                        Mes = "";
                        break;
                    case 12:
                        Mes = "";
                        break;
                }

                        
                InteresesListBox.Items.Add(Mes+" " + Capital.ToString("N") + " Interés Ganado de "+Mes+": " + Interes);
                j++;             

            }

        }


        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {
            CalcularInteres();
        }
    }
}
