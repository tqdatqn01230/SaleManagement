using System;
using System.Collections.Generic;
using System.Linq;
using BussinessObject.Context;
using BussinessObject.Models;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        #region [ Using Singleton ]
        private static MemberDAO instance = null;
        public static readonly object instanceLock = new object();
        public static MemberDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Search Member By - ]
        public IEnumerable<Member> FilterMemberByString(string name) {
            var MemberList = new List<Member>();
            try {
                using var context = new SaleManagementContext();
                MemberList = context.Members.Where(x => x.Email.Contains(name)).
                                                        ToList(); 
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return MemberList;
        }
        //|| x.CompanyName.Contains(name, StringComparison.InvariantCultureIgnoreCase)
        //|| x.Country.Contains(name, StringComparison.InvariantCultureIgnoreCase)
        //|| x.City.Contains(name, StringComparison.InvariantCultureIgnoreCase)
        #endregion

        #region [ Login ]
        public Member Login(string email, string password) {
            Member _tempMember = null;
            try {
                using var context = new SaleManagementContext();
                _tempMember = context.Members.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempMember;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<Member> GetMemberList() {
            var MemberList = new List<Member>();
            try {
                using var context = new SaleManagementContext();
                MemberList = context.Members.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return MemberList;
        }

        public Member GetMemberByEmail(string email) {
            Member _tempMember = null;
            try {
                using var context = new SaleManagementContext();
                _tempMember = context.Members.FirstOrDefault(x => x.Email.Equals(email));
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempMember;
        }

        public Member GetMemberById(int id) {
            Member _tempMember = null;
            try {
                using var context = new SaleManagementContext();
                _tempMember = context.Members.FirstOrDefault(x => x.MemberId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempMember;
        }

        public void AddMember(Member _Member) {
            try {
                var _tempMember = this.GetMemberById(_Member.MemberId);
                if (_tempMember == null) {
                    using var context = new SaleManagementContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Members.Add(_Member);
                    context.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateMember(Member _Member) {
            try {
                Member tempMember = this.GetMemberById(_Member.MemberId);
                if (tempMember != null) {
                    using var context = new SaleManagementContext();
                    context.Members.Update(_Member);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Member Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveMember(Member _Member) {
            try {
                Member _tempMember = this.GetMemberById(_Member.MemberId);
                if (_tempMember != null) {
                    using var context = new SaleManagementContext();
                    context.Members.Remove(_tempMember);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Member Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
