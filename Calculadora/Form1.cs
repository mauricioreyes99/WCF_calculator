using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            using (Referencia_servicio.CalculatorWCFClient WS = new Referencia_servicio.CalculatorWCFClient())
            {
                if(comboBox1.Text == "Suma")
                {
                    MessageBox.Show("El resultado es " + WS.Suma(num1, num2));
                }
                if (comboBox1.Text == "Resta")
                {
                    MessageBox.Show("El resultado es " + WS.Resta(num1, num2));
                }
                if (comboBox1.Text == "Multiplicacion")
                {
                    MessageBox.Show("El resultado es " + WS.Multiplicacion(num1, num2));
                }
                if (comboBox1.Text == "Division")
                {
                    MessageBox.Show("El resultado es " + WS.Division(num1, num2));
                }
            }

            
        }
    }
}
