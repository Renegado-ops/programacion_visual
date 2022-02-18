using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class FormColorPicker : Form
    {
        public FormColorPicker()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cambia el color del fondo

            //BackColor = Color.FromArgb(7,150,0);

           //Obterner los valores

            int red, green, blue;
            red = (int)numericUpDownRed.Value;
            green = (int)numericUpDownGreen.Value;
            blue = (int)numericUpDownBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAplicar2_Click(object sender, EventArgs e)
        {
            // cambiar el color del fondo

            //Obtener el valor

            int red, green, blue;
            red = (int)trackBarRed.Value;
            green = (int)trackBarGreen.Value;
            blue = (int)trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormColorPicker_Load(object sender, EventArgs e)
        {

        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarGreen.Value.ToString();

            // cambiar el color del fondo

            //Obtener el valor

            int red, green, blue;
            red = (int)trackBarRed.Value;
            green = (int)trackBarGreen.Value;
            blue = (int)trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarRed.Value.ToString();

            // cambiar el color del fondo

            //Obtener el valor

            int red, green, blue;
            red = (int)trackBarRed.Value;
            green = (int)trackBarGreen.Value;
            blue = (int)trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarBlue.Value.ToString();

            // cambiar el color del fondo

            //Obtener el valor

            int red, green, blue;
            red = (int)trackBarRed.Value;
            green = (int)trackBarGreen.Value;
            blue = (int)trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
