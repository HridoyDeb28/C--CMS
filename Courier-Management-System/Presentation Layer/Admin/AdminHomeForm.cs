using Final_Project.Presentation_Layer.Admin;
using Final_Project.Presentation_Layer.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Presentation_Layer
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void lblAddBranch_MouseEnter(object sender, EventArgs e)
        {
            lblAddBranch.BackColor = Color.Firebrick;

        }

        private void lblAddBranch_Click(object sender, EventArgs e)
        {
             AdminAddBranchForm adminAdd = new AdminAddBranchForm();
             adminAdd.Show();
             this.Hide();
            
        }

        private void lblAddBranch_MouseLeave(object sender, EventArgs e)
        {
            lblAddBranch.BackColor = Color.DimGray;
        }

        private void lblAllBranch_MouseLeave(object sender, EventArgs e)
        {
            lblAllBranch.BackColor = Color.DimGray;
        }

        private void lblAllBranch_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(1);
            adminShow.Show();
            this.Hide();
        }

        private void lblAllBranch_MouseEnter(object sender, EventArgs e)
        {
            lblAllBranch.BackColor = Color.Firebrick;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DimGray;
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Firebrick;
        }

        private void AdminHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblWorkerList_MouseEnter(object sender, EventArgs e)
        {
            lblWorkerList.ForeColor = Color.Red;
        }

        private void lblWorkerList_MouseLeave(object sender, EventArgs e)
        {
            lblWorkerList.ForeColor = Color.Black;
        }

        private void lblAddWorker_Click(object sender, EventArgs e)
        {
            AdminAddWorkerForm adminAddWorker = new AdminAddWorkerForm();
            adminAddWorker.Show();
            this.Hide();
        }

        private void lblAddWorker_MouseLeave(object sender, EventArgs e)
        {
            lblAddWorker.ForeColor = Color.Black;
        }

        private void lblAddWorker_MouseEnter(object sender, EventArgs e)
        {
            lblAddWorker.ForeColor = Color.Red;
        }

        private void lblSolveWorkerProblem_MouseEnter(object sender, EventArgs e)
        {
            lblSolveWorkerProblem.ForeColor = Color.Red;
        }

        private void lblSolveWorkerProblem_MouseLeave(object sender, EventArgs e)
        {
            lblSolveWorkerProblem.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWorkerList_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(2);
            adminShow.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblWorkerListIcon_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(2);
            adminShow.Show();
            this.Hide();
        }

        private void lblSolveWorkerProblem_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(3);
            adminShow.Show();
            this.Hide();
        }

        private void lblSolveWorkerProblemIcon_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(3);
            adminShow.Show();
            this.Hide();
        }
    }
}
