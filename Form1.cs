using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "1";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
           {
               if (NIP.TextLength < 4)
                {
                    NIP.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "2";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "2";
                }
            }
        }
        //boton de borrar
        private void button11_Click(object sender, EventArgs e)
        {
            CUENTA.Clear();
            NIP.Clear();
        }
        //boton de aceptar
        private void button12_Click(object sender, EventArgs e)
        {
            if (CUENTA.Text == "12345")
            {
                if (NIP.Text == "1234")
                {
                    MessageBox.Show("Datos correctos");
                }
                else
                {
                    MessageBox.Show("NIP incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Cuenta incorrecta");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "3";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "3";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "4";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "5";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "5";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "6";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "6";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "7";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "8";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "8";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "9";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CUENTA.TextLength < 5)
            {
                CUENTA.Text += "0";
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "";
                }
            }
            else
            {
                if (NIP.TextLength < 4)
                {
                    NIP.Text += "0";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}




























































































































































































































