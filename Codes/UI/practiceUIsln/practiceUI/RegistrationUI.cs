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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textCPassword_TextChanged(object sender, EventArgs e)
        {
            if(textPassword.Text!=textCPassword.Text)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
