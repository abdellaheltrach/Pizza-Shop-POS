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
            rbnMed.Checked = true;
            radioButton6.Checked = true;
            radioButton7.Checked = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            


        }

        private void rbnSmall_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = rbnSmall.Text;

            if (rbnSmall.Checked==true)
            {
                if (label10.Text == "$")
                {
                    label10.Text += rbnSmall.Tag;
                }
                else 
                {
                    string stringPart = label10.Text.Substring(0,1);
                    int numPart =Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += Convert.ToInt32(rbnSmall.Tag);
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {

                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart -= Convert.ToInt32(rbnSmall.Tag);
                    label10.Text = stringPart + numPart.ToString();



            }
                if (label10.Text == "$0")
                {
                label10.Text = "$";
                }

        }

        private void rbnMed_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = rbnMed.Text;
            if (rbnMed.Checked == true)
            {
                if (label10.Text == "$")
                {
                    label10.Text += rbnMed.Tag;
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += Convert.ToInt32(rbnMed.Tag);
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {

                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= Convert.ToInt32(rbnMed.Tag);
                label10.Text = stringPart + numPart.ToString();



            }
            if (label10.Text == "$0")
            {
                label10.Text = "$";
            }

        }

        private void rbnLarg_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = rbnLarg.Text;
            if (rbnLarg.Checked == true)
            {
                if (label10.Text == "$")
                {
                    label10.Text += rbnLarg.Tag;
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += Convert.ToInt32(rbnLarg.Tag);
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {

                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= Convert.ToInt32(rbnLarg.Tag);
                label10.Text = stringPart + numPart.ToString();



            }
            if (label10.Text == "$0")
            {
                label10.Text = "$";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Extra Cheese";
            if (checkBox1.Checked==true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }


                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text=label4.Text.Replace($", {sentence}", "").Replace(sentence, "");



                if (label4.Text == string.Empty || label4.Text == ", " || label4.Text == ",")
                {
                    label4.Text = "No Toppings";
                }
                if (label4.Text[0]==',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }


                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

            if (label10.Text == "$0")
            {
                label10.Text = "$";
            }


        }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Mushrooms";
            if (checkBox2.Checked == true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";
                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }



                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text = label4.Text.Replace($", {sentence}", "").Replace(sentence, "");



                if (label4.Text == string.Empty || label4.Text == ", " || label4.Text == ",")
                {
                    label4.Text = "No Toppings";
                }
                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

                if (label10.Text == "$0")
                {
                    label10.Text = "$";
                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Tomatoes";
            if (checkBox3.Checked == true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }


                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text = label4.Text.Replace($", {sentence}", "").Replace(sentence, "");



                if (label4.Text == string.Empty || label4.Text == ", " || label4.Text == ",")
                {
                    label4.Text = "No Toppings";
                }
                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }


                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

                if (label10.Text == "$0")
                {
                    label10.Text = "$";
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Onion";
            if (checkBox6.Checked == true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";


                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text = label4.Text.Replace($", {sentence}", "").Replace(sentence, "");

                if (label6.Text[0] == ',' && label6.Text[1] == ' ')
                {
                    label6.Text = label6.Text.Substring(2);
                }

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }


                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

                if (label10.Text == "$0")
                {
                    label10.Text = "$";
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Olive";
            if (checkBox5.Checked == true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text = label4.Text.Replace($", {sentence}", "").Replace(sentence, "");

                if (label5.Text[0] == ',' && label5.Text[1] == ' ')
                {
                    label5.Text = label5.Text.Substring(2);
                }

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

                if (label10.Text == "$0")
                {
                    label10.Text = "$";
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string sentence = "Green Peppers";
            if (checkBox4.Checked == true)
            {
                if (label4.Text == "No Toppings")
                    label4.Text = $"{sentence}";
                else
                    label4.Text += $", {sentence}";

                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //
                if (label10.Text == "$")
                {
                    label10.Text += "05";
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += 05;
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {
                label4.Text = label4.Text.Replace($", {sentence}", "").Replace(sentence, "");



                if (label4.Text == string.Empty || label4.Text == ", " || label4.Text == ",")
                {
                    label4.Text = "No Toppings";
                }
                if (label4.Text[0] == ',' && label4.Text[1] == ' ')
                {
                    label4.Text = label4.Text.Substring(2);
                }

                //


                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= 05;
                label10.Text = stringPart + numPart.ToString();

                if (label10.Text == "$0")
                {
                    label10.Text = "$";
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = radioButton6.Text;
            if (radioButton6.Checked == true)
            {
                if (label10.Text == "$")
                {
                    label10.Text += radioButton6.Tag;
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += Convert.ToInt32(radioButton6.Tag);
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {

                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= Convert.ToInt32(radioButton6.Tag);
                label10.Text = stringPart + numPart.ToString();



            }
            if (label10.Text == "$0")
            {
                label10.Text = "$";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = radioButton5.Text;
            if (radioButton5.Checked == true)
            {
                if (label10.Text == "$")
                {
                    label10.Text += radioButton5.Tag;
                }
                else
                {
                    string stringPart = label10.Text.Substring(0, 1);
                    int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                    numPart += Convert.ToInt32(radioButton5.Tag);
                    label10.Text = stringPart + numPart.ToString();
                }

            }
            else
            {

                string stringPart = label10.Text.Substring(0, 1);
                int numPart = Convert.ToInt32(label10.Text.Substring(1, 2));
                numPart -= Convert.ToInt32(radioButton5.Tag);
                label10.Text = stringPart + numPart.ToString();



            }
            if (label10.Text == "$0")
            {
                label10.Text = "$";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = radioButton7.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = radioButton4.Text;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                btnRest.Enabled = true;
                btnOrderPizza.Enabled = false;

            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                btnRest.Enabled = false;
                btnOrderPizza.Enabled = true;
            }
        }
    }
}
