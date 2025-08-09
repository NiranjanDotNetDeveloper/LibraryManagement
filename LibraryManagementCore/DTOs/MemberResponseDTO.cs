using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class MemberResponseDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateOnly? MembershipDate { get; set; }
        public string? MembershipType { get; set; }
    }
    public static class ConvertMemberResponseEntity
    {
        public static MemberResponseDTO ConvertMemberResponseDTOToMember(this Member memberResponseDTO)
        {
            MemberResponseDTO member = new MemberResponseDTO();
            member.MembershipDate = memberResponseDTO.MembershipDate;
            member.Email = memberResponseDTO.Email;
            member.Name = memberResponseDTO.Name;
            member.MembershipType = memberResponseDTO.MembershipType;
            return member;
        }

    }
}
