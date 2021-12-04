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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }


        List<int> ListaMostrar = new List<int>();

        public void MostrarNumeros()
        {

            string Nombre = "";
            string Apellido = "";

            Nombre = NombreTextBox.Text;
            Apellido = ApellidoTextBox.Text;

            for (int i = 1; i <= 100; i++)
            {
               if(i % 3 == 0 && i % 5 == 0)
                {
                    MostrarListBox.Items.Add(i+"  "+Nombre+" "+Apellido);
                }

                else if (i % 3 == 0)
                {
                    MostrarListBox.Items.Add(i + "  " + Nombre);
                }

                else if(i % 5 == 0)
                    {
                        MostrarListBox.Items.Add(i + "  " + Apellido);
                    }

                else
                {
                    MostrarListBox.Items.Add(i);
                }


            }

        }


        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MostrarNumeros();
        }
    }
}
