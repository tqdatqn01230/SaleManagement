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
    public partial class frmMemberUpdate : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        public frmMemberUpdate(Member _member) {
            InitializeComponent();
            this.AutoLoadDataInto_Inputs(_member);
        }

        private void btn_Member_Save_Click(object sender, EventArgs e) {
            var _tempMemberEmail = _memberRepository.GetMemberByEmail(tB_Member_Email.Text.ToString());
            var _tempMemberId = _memberRepository.GetMemberById(Int32.Parse(mTB_Member_Id.Text.ToString()));
            if (tB_Member_Email.Text.ToString().Equals("")
                || tB_Member_CompanyName.Text.ToString().Equals("")
                || tB_Member_City.Text.ToString().Equals("")
                || tB_Member_Country.Text.ToString().Equals("")
                || tB_Member_Password.Text.ToString().Equals("")
                || textBox1.Text.Equals("")) {
                MessageBox.Show("Invalid Input.");
            } else if ( _tempMemberEmail == null || _tempMemberEmail.MemberId == _tempMemberId.MemberId ) {
                var _tempMember = _memberRepository.GetMemberById(Int32.Parse(mTB_Member_Id.Text.ToString()));
                _tempMember.Email = tB_Member_Email.Text;
                _tempMember.CompanyName = tB_Member_CompanyName.Text;
                _tempMember.City = tB_Member_City.Text;
                _tempMember.Country = tB_Member_Country.Text;
                _tempMember.Password = tB_Member_Password.Text;
                _tempMember.FullName = textBox1.Text;
                _memberRepository.UpdateMember(_tempMember);
                this.Close();
                MessageBox.Show("Updated successfully");
            } else {
                MessageBox.Show("Member Email Address cannot be dupplicated.");
            }
        }

        private void btn_Member_Cancel_Click(object sender, EventArgs e) {
            var _tempMember = _memberRepository.GetMemberById(Int32.Parse(mTB_Member_Id.Text.ToString()));
            this.AutoLoadDataInto_Inputs(_tempMember);
        }

        public void AutoLoadDataInto_Inputs(Member _member) {
            mTB_Member_Id.Text = _member.MemberId.ToString();
            tB_Member_Email.Text = _member.Email.ToString();
            tB_Member_CompanyName.Text = _member.CompanyName.ToString();
            tB_Member_City.Text = _member.City.ToString();
            tB_Member_Country.Text = _member.Country.ToString();
            tB_Member_Password.Text = _member.Password.ToString();
            textBox1.Text = _member.FullName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
