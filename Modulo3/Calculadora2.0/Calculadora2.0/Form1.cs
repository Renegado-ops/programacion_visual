using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2_0
{
    public partial class formCalc : Form
    {
        public formCalc()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox_Num1.Text = "";
            textBox_Num2.Text = "";
            textBoxResultado.Text = "";

        }

        private void formCalc_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonResta_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonMutliplicacion_CheckedChanged(object sender, EventArgs e)
        {
            //declarar las variables
            string num1, num2;
            //asignarle un valor
            num1 = textBox_Num1.Text;
            num2 = textBox_Num2.Text;
        }

        private void radioButtonDivision_CheckedChanged(object sender, EventArgs e)
        {
            //declarar las variables
            string num1, num2;
            //asignarle un valor
            num1 = textBox_Num1.Text;
            num2 = textBox_Num2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declarar las variables
            string num1, num2;
            //asignarle un valor
            num1 = textBox_Num1.Text;
            num2 = textBox_Num2.Text;

            //validar variables

            if (num1.Trim() == "")
            {
                labelNum1.Visible = true;
                labelNum1.Text = "El nombre no puede estar vacio";
                textBox_Num1.Focus();
                return;
            }

            if (num2.Trim() == "")
            {
                labelNum2.Visible = true;
                labelNum2.Text = "El nombre no puede estar vacio";
                textBox_Num2.Focus();
                return;
            }

            if (radioButtonSuma.Checked)
            {
                //realizar el calculo
                int resultado = int.Parse(num1) + int.Parse(num2);
                textBoxResultado.Text = resultado.ToString();
            }

            if (radioButtonResta.Checked)
            {
                //realizar el calculo
                int resultado = int.Parse(num1) - int.Parse(num2);
                textBoxResultado.Text = resultado.ToString();
            }

            if (radioButtonMutliplicacion.Checked)
            {
                //realizar el calculo
                int resultado = int.Parse(num1) * int.Parse(num2);
                textBoxResultado.Text = resultado.ToString();
            }

            if (radioButtonDivision.Checked)
            {
                //realizar el calculo
                int resultado = int.Parse(num1) / int.Parse(num2);
                textBoxResultado.Text = resultado.ToString();
            }
        }

        private void labelNum1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_Num1_TextChanged(object sender, EventArgs e)
        {

                labelNum1.Visible = false;

        }

        private void labelNum2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_Num2_TextChanged(object sender, EventArgs e)
        {
                labelNum2.Visible = false;    
        }

        private void label_Num2_Click(object sender, EventArgs e)
        {

        }
    }
}
