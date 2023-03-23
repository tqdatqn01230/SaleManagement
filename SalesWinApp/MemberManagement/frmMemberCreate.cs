using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberCreate : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        public frmMemberCreate() {
            InitializeComponent();
        }

        private void btn_Member_Save_Click(object sender, EventArgs e) {
            int id = 0;
            try
            {
                id = int.Parse(mTB_Member_Id.Text.ToString());

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Id in wrong format");
                return;
            }
            var _tempMemberEmail = _memberRepository.GetMemberByEmail(tB_Member_Email.Text.ToString());
            var _tempMemberId = _memberRepository.GetMemberById(Int32.Parse(mTB_Member_Id.Text.ToString()));
            if (tB_Member_Email.Text.ToString().Equals("")
                || tB_Member_CompanyName.Text.ToString().Equals("")
                || tB_Member_City.Text.ToString().Equals("")
                || tB_Member_Country.Text.ToString().Equals("")
                || tB_Member_Password.Text.ToString().Equals("")
                || mTB_Member_Id.Text.ToString().Equals("")
                || textBox1.Text.Equals("")
                ) {
                MessageBox.Show("Invalid Input.");
            } else if (_tempMemberId != null) {
                MessageBox.Show("Member Id cannot be dupplicated.");
            } else if (_tempMemberEmail != null) {
                MessageBox.Show("Member Email Address cannot be dupplicated.");
            } else {
                var _tempMember = new Member();
                _tempMember.MemberId = Int32.Parse(mTB_Member_Id.Text.ToString());
                _tempMember.Email = tB_Member_Email.Text;
                _tempMember.FullName = textBox1.Text;
                _tempMember.CompanyName = tB_Member_CompanyName.Text;
                _tempMember.City = tB_Member_City.Text;
                _tempMember.Country = tB_Member_Country.Text;
                _tempMember.Password = tB_Member_Password.Text;

                _memberRepository.AddMember(_tempMember);
                this.Close();
                MessageBox.Show("Added successfully");
            }
        }

        private void btn_Member_Cancel_Click(object sender, EventArgs e) {
            this.ClearInputs();
        }

        public void ClearInputs() {
            tB_Member_Email.Clear();
            tB_Member_CompanyName.Clear();
            tB_Member_City.Clear();
            tB_Member_Country.Clear();
            tB_Member_Password.Clear();

        }

        private void frmMemberCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
