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

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            SalarioActualTextBox.Clear();
            VentasPromTextBox.Clear();
            AntiguedadTextBox.Clear();
            NuevoSalarioTextBox.Clear();

        }

        public int CalculoEdad(DateTime FechaNac)
        {
            DateTime _FechaNac = FechaNac;
            DateTime _FechaActual = DateTime.Now;

            int Edad;

            if (_FechaNac.Year >= _FechaActual.Year)
            {
                return 0;
            }
            else
            {
                Edad = _FechaActual.Year - _FechaNac.Year;
                if (_FechaNac.Month > _FechaActual.Month)
                {
                    Edad--;
                }
                return Edad;
            }

        }


        public double NuevoSalario(double SalarioActual, double VentasProm, double Antiguedad)
        {


            if (VentasProm > 10000 && CalculoEdad(Convert.ToDateTime(FechaNacTimePicker.Value)) >= 30 && Antiguedad >= 10)
            {
                return SalarioActual * 1.05;
            }
            else
            {
                return SalarioActual;
            }


        }

        private void CalcularSueldoButton_Click(object sender, EventArgs e)
        {
            NuevoSalarioTextBox.Text = NuevoSalario(Convert.ToDouble(SalarioActualTextBox.Text),
                                  Convert.ToDouble(VentasPromTextBox.Text), Convert.ToDouble(AntiguedadTextBox.Text)).ToString();
        }

      
    }
}
