using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class AdminForm : Form
    {
        
        public AdminForm()
        {
            InitializeComponent();
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployeedata employeedata = new ShowEmployeedata();
            employeedata.MdiParent = this;
            employeedata.WindowState = FormWindowState.Maximized;
            employeedata.Dock = DockStyle.Fill;
            employeedata.Show();
            
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }
    }
}
