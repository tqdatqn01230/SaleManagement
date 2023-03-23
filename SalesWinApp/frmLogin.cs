using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using SaleWinApp;
using System;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        MemberRepository memRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string AdminEmail = adminDefaultSettings.Email;
            string AdminPassword = adminDefaultSettings.Password;

            var tempMember = memRepository.Login(txtEmail.Text, txtPassword.Text);

            if (txtEmail.Text == AdminEmail && txtPassword.Text == AdminPassword)
            {
                this.Hide();
                var formManagement = new frmGeneralManagement();
                formManagement.Show();
            }
            else if (tempMember != null)
            {
                this.Hide();
                var formManagement = new frmPersonalManagement(tempMember);
                formManagement.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password. Please do it again");
                txtPassword.Clear();
            }
        }
    }


}