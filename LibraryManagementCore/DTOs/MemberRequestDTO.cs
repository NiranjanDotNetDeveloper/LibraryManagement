using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class MemberRequestDTO
    {
        public int MemoberId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateOnly? MembershipDate { get; set; }
        public string? MembershipType { get; set; }
    }
    public static class ConvertMemberEntity
    {
        public static Member ConvertMemberRequestDTOToMember(this MemberRequestDTO memberRequestDTO)
        {
            Member member = new Member();
            member.MemoberId= memberRequestDTO.MemoberId;
            member.MembershipDate = memberRequestDTO.MembershipDate;
            member.Email = memberRequestDTO.Email;
            member.Name=memberRequestDTO.Name;
            member.MembershipType = memberRequestDTO.MembershipType;
            return member;
        }

    }
}
