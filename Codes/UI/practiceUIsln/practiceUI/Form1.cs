using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceUI
{
    public partial class Form1 : Form
    {
        bool change=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: "+textBox1.Text+" "+textBox2.Text+" ");
            button1.BackColor = Color.Aqua;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") && change == false)
            {
                textBox1.Text = "First Name";
            }
            else
                change = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("First Name"))
            {
                change = true;
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("") && change == false)
            {
                textBox2.Text = "Last Name";
            }
            else
                change = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("Last Name"))
            {
                change = true;
                textBox2.Text = "";
            }
        }
    }
}
