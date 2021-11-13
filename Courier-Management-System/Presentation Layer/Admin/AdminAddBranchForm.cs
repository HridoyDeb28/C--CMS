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
    public partial class AdminAddBranchForm : Form
    {
        public AdminAddBranchForm()
        {
            InitializeComponent();
        }

        private void AdminAddBranchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            BranchService branchService = new BranchService();
            branchService.InsertBranch(txtBranchName.Text,txtAddress.Text);
            MessageBox.Show("Branch Added");
            AdminShowForm asf = new AdminShowForm(1);
            asf.Show();
            this.Hide();
            txtBranchName.Text = "";
            txtAddress.Text = "";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            AdminHomeForm ah = new AdminHomeForm();
            ah.Show();
            this.Hide();
        }
    }
}
