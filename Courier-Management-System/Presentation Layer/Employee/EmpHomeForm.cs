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

namespace Final_Project.Presentation_Layer.Employee
{
    public partial class EmpHomeForm : Form
    {
        int id;
        public EmpHomeForm()
        {
            InitializeComponent();
        }

        public EmpHomeForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void lblShipOrder_MouseEnter(object sender, EventArgs e)
        {
            lblShipOrder.ForeColor = Color.Red;
        }

        private void lblShipOrder_MouseLeave(object sender, EventArgs e)
        {
            lblShipOrder.ForeColor = Color.Black;
        }

        private void lblReceiveOrder_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(3,id);
            es.Show();
            this.Hide();
        }

        private void lblReceiveOrder_MouseEnter(object sender, EventArgs e)
        {
            lblReceiveOrder.ForeColor = Color.Red;
        }

        private void lblReceiveOrder_MouseLeave(object sender, EventArgs e)
        {
            lblReceiveOrder.ForeColor = Color.Black;
        }

        private void lblHelpLine_MouseEnter(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.Red;

        }

        private void lblHelpLine_MouseLeave(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.Black;
        }

        private void lblReleaseOrder_MouseLeave(object sender, EventArgs e)
        {
            lblReleaseOrder.ForeColor = Color.Black;
        }

        private void lblReleaseOrder_MouseEnter(object sender, EventArgs e)
        {
            lblReleaseOrder.ForeColor = Color.Red;

        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(1,id);
            es.Show();
            this.Hide();
        }

        private void lblProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.ForeColor = Color.Black;
        }

        private void lblProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.ForeColor = Color.Red;
        }

        private void lblEditProfile_MouseEnter(object sender, EventArgs e)
        {
            //lblEditProfile.ForeColor = Color.Red;
        }

        private void lblEditProfile_MouseLeave(object sender, EventArgs e)
        {
            //lblEditProfile.ForeColor = Color.Black;
        }

        private void lblServiceHistory_MouseLeave(object sender, EventArgs e)
        {
            lblServiceHistory.ForeColor = Color.Black;
        }

        private void lblServiceHistory_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblServiceHistory_MouseEnter(object sender, EventArgs e)
        {
            lblServiceHistory.ForeColor = Color.Red;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Black;
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Red;
        }

        private void EmpHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblHelpLine_Click(object sender, EventArgs e)
        {
            EmpHelpline eh = new EmpHelpline(id);
            eh.Show();
            this.Hide();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            EmpProfile ep = new EmpProfile(id);
            ep.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblShipOrder_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(2,id);
            es.Show();
            this.Hide();
        }

        private void lblShipOrderIcon_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(2,id);
            es.Show();
            this.Hide();
        }

        private void lblReceiveOrderIcon_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(3,id);
            es.Show();
            this.Hide();
        }

        private void lblReleaseOrder_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(4,id);
            es.Show();
            this.Hide();
        }

        private void lblReleaseOrderIcon_Click(object sender, EventArgs e)
        {
            EmpShowForm es = new EmpShowForm(4,id);
            es.Show();
            this.Hide();
        }

        private void lblHelpLineIcon_Click(object sender, EventArgs e)
        {
            EmpHelpline eh = new EmpHelpline(id);
            eh.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            NewOrderForm nof = new NewOrderForm(id);
            nof.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }
    }
}
