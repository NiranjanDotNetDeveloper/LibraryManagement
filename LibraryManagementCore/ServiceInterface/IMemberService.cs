using LibraryCore.Domain.Entity;
using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceInterface
{
    public interface IMemberService
    {
        List<MemberResponseDTO> GetAllMembers();
        MemberResponseDTO AddNewMember(MemberRequestDTO memberRequest);
        MemberResponseDTO UpdateExistingMember(string name, MemberRequestDTO memberRequest);
        bool RemoveMember(string name);
        MemberResponseDTO FindMemberByName(string name);
    }
}
