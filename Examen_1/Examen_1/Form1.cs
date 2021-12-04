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
  

        List<float> listaIntereses = new List<float>();


        public void CalcularInteres()
        {
            float Interes = 0F;
            float i = 0.015F;
            float Capital = 200000F;
            int Tiempo = 12;
            string Mes = "";

            for (int j = 1; j <= 12; j++)
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
                        Mes = "Marzo";
                        break;
                    case 4:
                        Mes = "Abril";
                        break;
                    case 5:
                        Mes = "Mayo";
                        break;
                    case 6:
                        Mes = "Junio";
                        break;
                    case 7:
                        Mes = "Julio";
                        break;
                    case 8:
                        Mes = "Agosto";
                        break;
                    case 9:
                        Mes = "Septiembre";
                        break;
                    case 10:
                        Mes = "Octubre";
                        break;
                    case 11:
                        Mes = "Noviembre";
                        break;
                    case 12:
                        Mes = "Diciembre";
                        break;
                }

                InteresesListBox.Items.Add(Mes);
                InteresesListBox.Items.Add("Capital Actual: " + Capital.ToString("N") + " Interés Ganado " + Interes);
                InteresesListBox.Items.Add("");

            }

        }


        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {
            CalcularInteres();
        }
    }
}
