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

            for (int j = 1; j <= 100; j++)
            {
               
                MostrarListBox.Items.Add(Nombre);
                MostrarListBox.Items.Add(Apellido);

            }

        }


        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MostrarNumeros();
        }
    }
}
