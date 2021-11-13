using Final_Project.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Presentation_Layer.Employee
{
    public partial class EmpProfile : Form
    {
        int id;
        public EmpProfile()
        {
            InitializeComponent();
        }

        public EmpProfile(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EmpProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            EmpHomeForm empHomeForm = new EmpHomeForm(id);
            empHomeForm.Show();
            this.Hide();
        }

        public string getDesignation(int id)
        {
            if(id == 0)
            {
                return "Manager";
            }
            else if(id == 1)
            {
                return "Worker";
            }
            else if(id == 2)
            {
                return "Driver";
            }
            else
            {
                return "Delivery Boy";
            }
        }
        private void EmpProfile_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            Entities.Employee employee = employeeService.GetEmployee(id);
            lblName1.Text = employee.Name;
            lblDesignation1.Text = getDesignation(employee.Designation);
            lblDateOfBirth1.Text = employee.DOB;
            lblBloodGroup1.Text = employee.Blood_Group;
            lblContact1.Text = employee.Contact;
            lblAddress1.Text = employee.Address;

        }

        private void lblBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
