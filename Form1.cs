using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Shop_POS
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
            MessageBox.Show("Hello World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Welcome");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Welcome",MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) ;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello World!", "Welcome", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hello World!", "Welcome", MessageBoxButtons.OKCancel,
MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("You selected OK");
            }
            else
            {
                MessageBox.Show("You selected Cancel");
            }
        }
    }
}
