using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;

namespace UI
{
    public partial class LoginForm : Form
    {
        AdminForm _form = new AdminForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessLogin login = new BusinessLogin();
            if (login.Login(tbUserID.Text, tbPassword.Text))
            {
                if (true)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Login Failed!", "Waring!"
                    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            this.btnLogin.Enabled = true;
        }
    }
}
