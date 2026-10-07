using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dato1.Clear();
            Dato2.Clear();
            RESULT.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(Dato1.Text);
            int Num2 = Convert.ToInt32(Dato2.Text);

            string resultado = "";
            resultado += "Multiplicacion: " + (Num1 * Num2) + "\n";
            RESULT.Text = resultado;

        }

        private void suma_Click(object sender, EventArgs e)
        {

            int Num1 = Convert.ToInt32(Dato1.Text);
            int Num2 = Convert.ToInt32(Dato2.Text);

            string resultado = "";
            resultado += "Suma: " + (Num1 + Num2) + "\n";
            RESULT.Text = resultado;

        }

        private void resta_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(Dato1.Text);
            int Num2 = Convert.ToInt32(Dato2.Text);

            string resultado = "";
            resultado += "Resta: " + (Num1 - Num2) + "\n";
            RESULT.Text = resultado;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(Dato1.Text);
            int Num2 = Convert.ToInt32(Dato2.Text);

            string resultado = "";
            resultado += "Division: " + ((double)Num1 / Num2) + "\n";
            RESULT.Text = resultado;

        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(Dato1.Text);
            int Num2 = Convert.ToInt32(Dato2.Text);

            string resultado = "";
            resultado += "Raiz del primer numero: " + Math.Sqrt(Num1) + "\n";
            resultado += "Raiz del segundo valor: " + Math.Sqrt(Num2) + "\n";


            RESULT.Text = resultado;

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


