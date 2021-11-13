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
    public partial class EmpHelpline : Form
    {
        int id;
        public EmpHelpline()
        {
            InitializeComponent();
        }

        public EmpHelpline(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ProblemIcon_Click(object sender, EventArgs e)
        {

        }

        private void EmpHelpline_Load(object sender, EventArgs e)
        {

        }

        private void EmpHelpline_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.ForeColor = Color.Red;
        }

        private void btnSend_MouseLeave(object sender, EventArgs e)
        {
            btnSend.ForeColor = Color.Red;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            EmpHomeForm empHomeForm  = new EmpHomeForm(id);
            empHomeForm.Show();
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            EmployeeProblemService eps = new EmployeeProblemService();
            int r= eps.InsertBranchProblem(rtbProblem.Text, id);
            if (r > 0)
            {
                MessageBox.Show("Problem has been submitted to the Admin");
                EmpHomeForm ehf = new EmpHomeForm(id);
                ehf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!");
            }
        }
    }
}
