using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace URS
{
    public partial class LoginInterface : Form
    {

        public LoginInterface()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginController login_controller = new LoginController();

            if (!GLOBALS.isAlphaNumeric(txtUsername.Text)
                || !GLOBALS.isAlphaNumeric(txtPassword.Text))
            {
                return;
            }

            if (login_controller.validateLogin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Success!");
                this.Hide();
                if (Member.membership_type == "administrator" || Member.membership_type == "data entry operator")
                {
                    HomePageAdmin homepage_admin = new HomePageAdmin();
                    homepage_admin.ShowDialog();
                }
                else if (Member.membership_type == "student" || Member.membership_type == "faculty")
                {
                    HomePage homepage = new HomePage();
                    homepage.ShowDialog();
                }

                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Your username and password are not match!");
            }
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {

        }

    }
}
