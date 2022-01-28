using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Member
    {
        [Key]
        public int MembersId { get; set; }
        public string MembersName { get; set; }
        public string MemberslastName { get; set; }
        public string Memberspassword{ get; set; }
        public string Membersmobilenumbe { get; set; }

    }
}
