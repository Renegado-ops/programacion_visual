using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Este mensaje se deberia ver");
            string semana;
            semana = textBox.Text;

            if (semana == "1")
            {
                MessageBox.Show("Lunes");
            } 

            if (semana == "2")
            {
                MessageBox.Show("Martes");
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("La tecla es");
            MessageBox.Show(e.KeyValue.ToString());
        }
    }
}
