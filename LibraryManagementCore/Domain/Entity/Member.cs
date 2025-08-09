using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCore.Domain.Entity
{
    public class Member
    {
        [Key]
        public int MemoberId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateOnly? MembershipDate { get; set; }
        public string? MembershipType { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
