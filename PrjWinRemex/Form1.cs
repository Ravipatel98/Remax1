using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinRemex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check_empty();

        }

        public Boolean check_empty()

        {

            if(txtUsername.Text.Trim().Equals(""))
            {
               
                MessageBox.Show("Username is empty");
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
               
                MessageBox.Show("Password is empty");
                txtPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
