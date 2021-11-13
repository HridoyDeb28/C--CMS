using Final_Project.Business_Layer;
using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Presentation_Layer.Admin
{
    public partial class AdminAddWorkerForm : Form
    {
        public AdminAddWorkerForm()
        {
            InitializeComponent();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void AdminAddWorkerForm_Load(object sender, EventArgs e)
        {
            BranchService branchservice = new BranchService();
            List<Branch> branch = branchservice.GetBranchData();
            DataTable dt = ConvertToDataTable.ToDataTable<Branch>(branch);
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.DataSource = dt;
            cmbDesignation.SelectedItem = "Manager";
        }

        private void AdminAddWorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private int getDesignation()
        {
            string designation = cmbDesignation.SelectedItem.ToString();
            int desig;
            if (designation.Equals("Manager"))
            {
                desig = 0;
            }
            else if (designation.Equals("Worker"))
            {
                desig = 1;
            }
            else if (designation.Equals("Driver"))
            {
                desig = 2;
            }
            else
            {
                desig = 3;
            }

            return desig;
        }

        public int add_user()
        {
            UserService userService = new UserService();
            userService.InsertUsers(txtUserName.Text, txtPassword.Text, txtEmail.Text, 1, false);
            int id= userService.getIdByUserName(txtUserName.Text);
            return id;
        }
        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            int userid = add_user();
            EmployeeService employeeService = new EmployeeService();
            employeeService.AddEmployee(txtName.Text, DateTime.Now.ToString(),DateTime.Now.AddYears(-20).ToString(), Int32.Parse(txtSalary.Text), 0, txtContact.Text, txtAddress.Text, getDesignation(), Int32.Parse(cmbBranch.SelectedValue.ToString()),cmbBloodGroup.SelectedItem.ToString(), userid);
            MessageBox.Show("Employee Added");
            AdminShowForm asf = new AdminShowForm(2);
            asf.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            AdminHomeForm ah = new AdminHomeForm();
            ah.Show();
            this.Hide();
        }
    }
}
