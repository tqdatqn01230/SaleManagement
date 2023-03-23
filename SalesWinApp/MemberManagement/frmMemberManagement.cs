using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberManagement : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        IEnumerable<Member> _memberList = new List<Member>();
        public frmMemberManagement() {
            InitializeComponent();
            this.AutoLoadDataInto_DGV();
        }

        private void btn_MemberMana_Add_Click(object sender, EventArgs e) {
            var frmMemberCreate= new frmMemberCreate();
            frmMemberCreate.Show();
        }

        private void btn_MemberMana_Update_Click(object sender, EventArgs e) {
            var tempMember = _memberRepository.GetMemberById(Int32.Parse(dgv_Members.SelectedRows[0].Cells[0].Value.ToString()));
            var frmMemberUpdate = new frmMemberUpdate(tempMember);
            frmMemberUpdate.ShowDialog();
        }

        private void btn_MemberMana_Delete_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Member?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var temp = _memberRepository.GetMemberById(Int32.Parse(dgv_Members.SelectedRows[0].Cells[0].Value.ToString()));
                _memberRepository.RemoveMember(temp);
                this.AutoLoadDataInto_DGV();
                MessageBox.Show("Deleted the chosen member.");
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e) {
            this.AutoLoadDataInto_DGV();
        }

        #region [ DGV - Functions ]
        private void dgv_Members_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_Members.SelectedRows.Count == 1) {
                btn_MemberMana_Delete.Enabled = true;
                btn_MemberMana_Update.Enabled = true;
            }else {
                btn_MemberMana_Delete.Enabled = false;
                btn_MemberMana_Update.Enabled=false;
            }
        }

        public void AutoLoadDataInto_DGV() {
            _memberList = _memberRepository.GetMemberList();
            this.LoadDataInto_DGV(_memberList);
        }

        public void LoadDataInto_DGV(IEnumerable<Member> _memberList) {
            dgv_Members.Rows.Clear();
            foreach (var member in _memberList) {
                dgv_Members.Rows.Add(member.MemberId, member.Email, member.FullName, member.CompanyName, member.City,member.Country);
            }
        }


        #endregion

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
