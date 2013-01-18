using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int tes;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == " ")
            {
                if (tes == 0)
                {
                    button1.Text = "○";
                }
                else if (tes == 1)
                {
                    button1.Text = "×";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tes = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tes = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == " ")
            {
                if (tes == 0)
                {
                    button4.Text = "○";
                }
                else if (tes == 1)
                {
                    button4.Text = "×";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == " ")
            {
                if (tes == 0)
                {
                    button5.Text = "○";
                }
                else if (tes == 1)
                {
                    button5.Text = "×";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == " ")
            {
                if (tes == 0)
                {
                    button6.Text = "○";
                }
                else if (tes == 1)
                {
                    button6.Text = "×";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == " ")
            {
                if (tes == 0)
                {
                    button7.Text = "○";
                }
                else if (tes == 1)
                {
                    button7.Text = "×";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == " ")
            {
                if (tes == 0)
                {
                    button8.Text = "○";
                }
                else if (tes == 1)
                {
                    button8.Text = "×";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == " ")
            {
                if (tes == 0)
                {
                    button9.Text = "○";
                }
                else if (tes == 1)
                {
                    button9.Text = "×";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == " ")
            {
                if (tes == 0)
                {
                    button10.Text = "○";
                }
                else if (tes == 1)
                {
                    button10.Text = "×";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == " ")
            {
                if (tes == 0)
                {
                    button11.Text = "○";
                }
                else if (tes == 1)
                {
                    button11.Text = "×";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button10.Text = " ";
            button11.Text = " ";
        }
    }
}
