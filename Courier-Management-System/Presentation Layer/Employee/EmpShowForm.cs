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
    public partial class EmpShowForm : Form
    {
        int show,id;
        public EmpShowForm()
        {
            InitializeComponent();
            DataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public EmpShowForm(int show,int id)
        {
            InitializeComponent();
            DataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.show = show;
            this.id = id;
        }

        private void EmpShowForm_Load(object sender, EventArgs e)
        {
            if(show == 1)
            {
                ProductService productService = new ProductService();
                DataGridViewShow.DataSource = productService.getServiceHistory(id);
            }
            else if(show == 2)
            {
                ProductService productService = new ProductService();
                DataGridViewShow.DataSource = productService.getShipAbleProducts(id);
            }
            else if(show == 3)
            {
                ProductService productService = new ProductService();
                DataGridViewShow.DataSource = productService.getReceiveAbleProducts(id);

            }
            else if(show == 4)
            {
                ProductService productService = new ProductService();
                DataGridViewShow.DataSource = productService.getReleaseAbleProducts(id);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmpShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DataGridViewShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductService productService = new ProductService();
            if(show == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Do You want to Ship the Product?", "Product Shipping", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int r = productService.ShipProduct(id,(int)DataGridViewShow.Rows[e.RowIndex].Cells[0].Value);
                    if (r > 0)
                    {
                        MessageBox.Show("Product Shipped");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                    EmpShowForm_Load(sender, e);
                }
            }
            else if(show == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Do You want to Receive the Product?", "Product Receiving", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int r = productService.ReceiveProduct(id, (int)DataGridViewShow.Rows[e.RowIndex].Cells[0].Value);
                    if (r > 0)
                    {
                        MessageBox.Show("Product Received");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                    EmpShowForm_Load(sender, e);

                }
            }
            else if(show == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Do You want to Release the Product?", "Product Releasing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int r = productService.ReleaseProduct((int)DataGridViewShow.Rows[e.RowIndex].Cells[0].Value);
                    if (r > 0)
                    {
                        MessageBox.Show("Product Released");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                    EmpShowForm_Load(sender, e);
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            EmpHomeForm empHomeForm = new EmpHomeForm(id);
            empHomeForm.Show();
            this.Hide();
        }
    }
}
