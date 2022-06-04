using PayRolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRolManagementSystem.EmployeeBioData
{
    public partial class Employee : Form
    {
        PayrollManagementSystemEntities db = new PayrollManagementSystemEntities();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
           // List<tbl_departments> li = db.tbl_departments.OrderBy(x => x.dept_name).ToList();

            List<tbl_departments> li = db.tbl_departments.ToList();
            cmdept.DataSource = li;
            cmdept.DisplayMember = "dept_name";
            cmdept.ValueMember = "dept_id";

            udepartment.DataSource = li;
            udepartment.DisplayMember = "dept_name";
            udepartment.ValueMember = "dept_id";
            getEmployee();
        }

        public void getEmployee()
        {
            //dataGridView1.DataSource = db.tbl_employee.ToList();

            dataGridView1.DataSource = db.VW_GETEMPLOYEE.ToList();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_employee emp = new tbl_employee();
            emp.emp_name = txtname.Text;
            emp.emp_contact = txtcontact.Text;
            emp.emp_cnic = txtcnic.Text;
            emp.emp_dob = txtdob.Value;
            if (radioButton1.Checked)
            {
                emp.emp_gender = true;
            }
            else
            {
                emp.emp_gender = false;
            }
            emp.emp_email = txtemail.Text;
            emp.emp_hireDate = txthiredate.Value;
            emp.emp_status = true;
            emp.emp_image = "no Image";

            db.tbl_employee.Add(emp);
            db.SaveChanges();
           
     

            tbl_EmployeWorkingStatus st = new tbl_EmployeWorkingStatus();
            st.status_emp_fk = emp.emp_id;
            st.status_dep_fk = (int)cmdept.SelectedValue;
            st.status_year = System.DateTime.Now.Year;
            st.status_basicSalary = Convert.ToInt32(txtsalary.Text);
            st.status_bonus = Convert.ToInt32(txtbonus.Text);
            st.status_medical = Convert.ToInt32(txtmedical.Text);
            st.staus_casualLeave = Convert.ToInt32(txtcasualleave.Text);
            st.staus_sickLeave = Convert.ToInt32(txtsickleave.Text);
            st.staus_halfDays = Convert.ToInt32(txthalfdays.Text);
            st.staus_anualLeave = Convert.ToInt32(txtannualleave.Text);
 

            db.tbl_EmployeWorkingStatus.Add(st);
            db.SaveChanges();
          
         

            MessageBox.Show("Record has Successfully inserted in Database");


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void txthiredate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox13.Text);

           tbl_employee emp = db.tbl_employee.Where(x => x.emp_id == id).SingleOrDefault();

            if(emp!=null)
            {
                utxtname.Text = emp.emp_name;
                utxtphone.Text = emp.emp_contact;
                utxtcnic.Text = emp.emp_cnic;
                udob.Value = (DateTime)emp.emp_dob;
                utxtemail.Text = emp.emp_email;
                uhiredate.Value = (DateTime)emp.emp_hireDate;

                if (emp.emp_gender == true)
                {
                    urdmale.Checked = true;
                }
                else
                {
                    urdfemale.Checked = true;
                }
                tbl_EmployeWorkingStatus ewm = db.tbl_EmployeWorkingStatus.Where(x => x.status_emp_fk == emp.emp_id).SingleOrDefault();

                utxtsalary.Text = ewm.status_basicSalary.ToString();
                utxtbonus.Text = ewm.status_bonus.ToString();
                utxtmedical.Text = ewm.status_medical.ToString();
                utxtcasualleave.Text = ewm.staus_casualLeave.ToString();
                utxtsickleave.Text = ewm.staus_sickLeave.ToString();
                uhalfdays.Text = ewm.staus_halfDays.ToString();
                utxtannualleave.Text = ewm.staus_anualLeave.ToString();
            }
            else
            {
                MessageBox.Show("Sorry No Records were Found");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update code
            int id = Convert.ToInt32(textBox13.Text);

            tbl_employee emp = db.tbl_employee.Where(x => x.emp_id == id).SingleOrDefault();

            emp.emp_name = utxtname.Text;
            emp.emp_contact = utxtphone.Text;
            emp.emp_cnic = utxtcnic.Text;
            emp.emp_dob = udob.Value;

            if (urdfemale.Checked) { emp.emp_gender = false; }
            else { emp.emp_gender = true; }

            emp.emp_email = utxtemail.Text;

            if (checkBox1.Checked) { emp.emp_status = true ; }
            else { emp.emp_status = false; }

            db.SaveChanges();
            MessageBox.Show("Data Successfully Updated");
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbl_feedback fdb = new tbl_feedback();
            fdb.fb_name = fbtxtname.Text;
            fdb.fb_phone = fbtxtphone.Text;
            fdb.fb_email = fbtxtemail.Text;
            fdb.fb_company = fbtxtcompany.Text;
            fdb.fb_feedback = fbtxtfeedback.Text;
            db.tbl_feedback.Add(fdb);
            db.SaveChanges();
            MessageBox.Show("Your Feedback was Successfully Sent to Developers");
            //db.tbl_employee.Add(emp);
            //db.SaveChanges();
        }
    }
}
