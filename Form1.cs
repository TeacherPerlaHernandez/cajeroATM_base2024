using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cuenta.Clear();
            nip.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuenta.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             cuenta.Text = "2";
        }
    }
}
