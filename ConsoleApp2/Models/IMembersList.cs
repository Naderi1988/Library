using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public interface IMembersList
    {
        bool Insert(Member member);
        bool Update(int memberId, Member member);
        bool Delete(Member member);
        Member GetMemberById(int memberId);
        List<Member> GetAllMembers();
    }
}
