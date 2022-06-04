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
    public partial class Form2 : Form
    {
        PayrollManagementSystemEntities db = new PayrollManagementSystemEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_inquiry inq = new tbl_inquiry();
            inq.iq_name = iqtxtname.Text;
            inq.iq_email = iqtxtemail.Text;
            inq.iq_phone = iqtxtphone.Text;
            inq.iq_company = iqtxtcompany.Text;
            inq.iq_query = iqtxtquery.Text;
            db.tbl_inquiry.Add(inq);
            db.SaveChanges();
            MessageBox.Show("Your Query was Successfully Sent to Developers");
        }
    }
}
