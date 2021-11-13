using Final_Project.Business_Layer;
using Final_Project.Entities;
using Final_Project.Presentation_Layer.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Presentation_Layer.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            Users user = userService.Validate(txtUserName.Text,txtPassword.Text);
            if(user != null)
            {
                if(user.UserType == 0)
                {
                    AdminHomeForm ahf = new AdminHomeForm();
                    ahf.Show();
                    this.Hide();
                }
                else
                {
                    EmpHomeForm ehf = new EmpHomeForm(user.Id);
                    ehf.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password!!!");
            }
        }
    }
}
