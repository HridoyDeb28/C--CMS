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

namespace Final_Project.Presentation_Layer.Admin
{
    public partial class AdminShowForm : Form
    {
        int show;
        public AdminShowForm()
        {
            InitializeComponent();
            gridShowTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public AdminShowForm(int show)
        {
            InitializeComponent();
            this.show = show;
            gridShowTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AdminShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            AdminHomeForm ah = new AdminHomeForm();
            ah.Show();
            this.Hide();
        }

        private void AdminShowForm_Load(object sender, EventArgs e)
        {
            if(show == 1)
            {
                BranchService branchService = new BranchService();
                gridShowTable.DataSource = branchService.GetBranchData();
            }
            else if(show == 2)
            {
                EmployeeService employeeService = new EmployeeService();
                gridShowTable.DataSource = employeeService.GetEmployeeData();
            }
            else if(show == 3)
            {
                EmployeeProblemService employeeProblem = new EmployeeProblemService();
                gridShowTable.DataSource = employeeProblem.GetEmployeeProblemData();
            }
        }

        private void gridShowTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (show == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Want to delete the Branch?", "Branch Deletion", MessageBoxButtons.YesNo);
                BranchService branchService = new BranchService();
                if (dialogResult == DialogResult.Yes)
                {
                    branchService.DeletBranch((int)gridShowTable.Rows[e.RowIndex].Cells[0].Value);
                    AdminShowForm_Load(sender, e);
                }
              
            }
            else if (show == 2)
            {
                int id = (int)gridShowTable.Rows[e.RowIndex].Cells[10].Value;
                AdminViewWorker AdminView = new AdminViewWorker(id);
                AdminView.Show();
                this.Hide();
            }
            else if (show == 3)
            {
                int id = (int)gridShowTable.Rows[e.RowIndex].Cells[1].Value;
                MessageBox.Show(gridShowTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Resoponse to his problem now?", "Problem solving", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    EmployeeProblemService employeeProblem = new EmployeeProblemService();
                    employeeProblem.DeleteProblem(id);
                    AdminShowForm_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Problem Didn't solved you will get it later.");
                }
                
            }
        }
    }
}
