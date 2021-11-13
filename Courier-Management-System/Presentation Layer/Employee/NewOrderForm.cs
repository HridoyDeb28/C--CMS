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

namespace Final_Project.Presentation_Layer.Employee
{
    public partial class NewOrderForm : Form
    {
        int id;
        public NewOrderForm()
        {
            InitializeComponent();
        }
        public NewOrderForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            BranchService branchservice = new BranchService();
            List<Branch> branch = branchservice.GetBranchData();
            DataTable dt = ConvertToDataTable.ToDataTable<Branch>(branch);
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.DataSource = dt;

            DataTable dts = ConvertToDataTable.ToDataTable<Branch>(branch);
            cmbBrach1.DisplayMember = "Branch_Name";
            cmbBrach1.ValueMember = "Id";
            cmbBrach1.DataSource = dts;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            EmpHomeForm empHomeForm = new EmpHomeForm(id);
            empHomeForm.Show();
            this.Hide();
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            int r =productService.AddParcel(cmbSelectCategory.SelectedIndex,1,"",DateTime.Now.ToString(), Int32.Parse(cmbBrach1.SelectedValue.ToString()), Int32.Parse(cmbBranch.SelectedValue.ToString()), 100,0,0,cmbSelectCategory.SelectedIndex,cmbPaymentMethod.SelectedIndex,txtFullName.Text,txtEmail.Text,txtContactNumber.Text,txtAddress.Text,txtDesProduct.Text);
            if (r > 0)
            {
                MessageBox.Show("Product Added");
                EmpShowForm esf = new EmpShowForm(2,id);
                esf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!!");
            }

        }

        private void txtDesProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDesProduct.ForeColor = Color.Black;
        }

        private void txtDesProduct_Enter(object sender, EventArgs e)
        {
            if (txtDesProduct.Text.Equals("Describe the Product"))
            {
                txtDesProduct.Text = "";
            }
        }

        private void txtDesProduct_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtDesProduct_Leave(object sender, EventArgs e)
        {
            if (txtDesProduct.Text.Equals(""))
            {
                txtDesProduct.Text = "Describe the Product";
                txtDesProduct.ForeColor = Color.Gray;
            }
        }
    }
}
