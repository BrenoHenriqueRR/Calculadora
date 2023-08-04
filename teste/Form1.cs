using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha uma opçâo","",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float number1 = float.Parse(Txtbnumber1.Text);
            float number2 = float.Parse(TxtBnumber2.Text);
            float sum = number1 + number2;
            string text = number1 + "+" + number2 + " = " + sum;
            MessageBox.Show(text, "RESULTADO",
                            MessageBoxButtons.OK);
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(Txtbnumber1.Text);
            float number2 = float.Parse(TxtBnumber2.Text);
            float sum = number1 - number2;
            string text = number1 + "-" + number2 + " = " + sum;
            MessageBox.Show(text, "RESULTADO",
                            MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(Txtbnumber1.Text);
            float number2 = float.Parse(TxtBnumber2.Text);
            float sum = number1 / number2;
            string text = number1 + "/" + number2 + " = " + sum;
            MessageBox.Show(text, "RESULTADO",
                            MessageBoxButtons.OK);
        }

        private void btmultiplicação_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(Txtbnumber1.Text);
            float number2 = float.Parse(TxtBnumber2.Text);
            float sum = number1 * number2;
            string text = number1 + "x" + number2 + " = " + sum;
            MessageBox.Show(text, "RESULTADO",
                            MessageBoxButtons.OK);
        }
    }
}
