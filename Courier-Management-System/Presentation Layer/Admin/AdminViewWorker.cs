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
    public partial class AdminViewWorker : Form
    {
        int id;
        public AdminViewWorker()
        {
            InitializeComponent();
        }
        public AdminViewWorker(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AdminViewWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            AdminHomeForm ah = new AdminHomeForm();
            ah.Show();
            this.Hide();
        }

        private void AdminViewWorker_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            Final_Project.Entities.Employee employee = employeeService.GetEmployee(id);
            lblUserName.Text = employee.Name;
            txtSalary.Text = employee.Salary.ToString();
            txtBonus.Text = employee.Bonus.ToString();
            BranchService branchservice = new BranchService();
            List<Branch> branch = branchservice.GetBranchData();
            DataTable dt = ConvertToDataTable.ToDataTable<Branch>(branch);
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.DataSource = dt;
            cmbDesignation.SelectedItem = "Manager";
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.DeleteEmployee(id);
            UserService userService = new UserService();
            userService.DeleteUser(id);
            MessageBox.Show("User Deleted");
            AdminShowForm asf = new AdminShowForm(2);
            asf.Show();
            this.Hide();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            Entities.Employee employee = new Entities.Employee();
            employee.UserId = id;
            employee.Salary = Int32.Parse(txtSalary.Text);
            employee.Bonus = float.Parse(txtBonus.Text);
            employee.Designation = getDesignation();
            employee.Branch_id = Int32.Parse(cmbBranch.SelectedValue.ToString());
            if(employeeService.Update(employee) > 0)
            {
                MessageBox.Show("Employe's Info Updated");
                AdminShowForm asf = new AdminShowForm(2);
                asf.Show();
                this.Hide();
            }
        }
    }
}
