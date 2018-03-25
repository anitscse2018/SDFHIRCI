using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void LOG_BTN_Click(object sender, EventArgs e)
        {
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "admin" && pass == "admin")
            {
               // MessageBox.Show("successful");

                FrmSteganography s = new FrmSteganography();

                s.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
