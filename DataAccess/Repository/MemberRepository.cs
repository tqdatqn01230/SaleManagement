using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member _Member) => MemberDAO.Instance.AddMember(_Member);

        public IEnumerable<Member> FilterMemberByString(string name) => MemberDAO.Instance.FilterMemberByString(name);

        public Member GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);

        public Member GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);

        public IEnumerable<Member> GetMemberList() => MemberDAO.Instance.GetMemberList();

        public Member Login(string email, string password) => MemberDAO.Instance.Login(email, password);

        public void RemoveMember(Member _Member) => MemberDAO.Instance.RemoveMember(_Member);

        public void UpdateMember(Member _Member) => MemberDAO.Instance.UpdateMember(_Member);
    }
}
