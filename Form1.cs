using PayRolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRolManagementSystem
{
    public partial class Form1 : Form
    {
        PayrollManagementSystemEntities db = new PayrollManagementSystemEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void employeeRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please enter Usermame and Password");
                return;
            }
            string enteredID = txt_UserName.Text;
            string enteredPassword = txt_Password.Text;


            if (enteredID == "admin" || enteredPassword == "admin")
            {
                MessageBox.Show("Login Successfully, Please wait..");
                EmployeeBioData.Employee frm = new EmployeeBioData.Employee();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("You entered wrong Usermame or Password");
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
