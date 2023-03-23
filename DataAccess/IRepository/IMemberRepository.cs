using BussinessObject.Models;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> FilterMemberByString(string name);
        public Member Login(string email, string password);
        public IEnumerable<Member> GetMemberList();
        public Member GetMemberByEmail(string email);
        public Member GetMemberById(int id);
        public void AddMember(Member _Member);
        public void UpdateMember(Member _Member);
        public void RemoveMember(Member _Member);
    }
}
