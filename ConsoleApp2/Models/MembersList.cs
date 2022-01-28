using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class MembersList : IMembersList
    {
        private LibraryContext db;

        public MembersList(LibraryContext _libraryContext)
        {
            this.db = _libraryContext;
        }
        
       
        public bool Delete(Member member)
        {
            db.Members.Remove(member);
            db.SaveChanges();
            return true;
        }

        public List<Member> GetAllMembers()
        {
            return db.Members.ToList();
        }

        public Member GetMemberById(int memberId)
        {
            return db.Members.Find(memberId);
        }

        public bool Insert(Member member)
        {
            try
            {
                db.Members.Add(member);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int memberId, Member member)
        {
            Member oldMember = GetMemberById(memberId);

            oldMember.MemberslastName = member.MemberslastName;
            oldMember.MembersName = member.MembersName;
            oldMember.Membersmobilenumbe = member.Membersmobilenumbe;
            oldMember.Memberspassword = member.Memberspassword;

            db.SaveChanges();
            return true;
        }
    }
}
