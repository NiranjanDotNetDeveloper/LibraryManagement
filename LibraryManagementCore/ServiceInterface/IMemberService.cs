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
        List<MemberResponseDTO> GetAllMembers(MemberRequestDTO memberRequest);
        MemberResponseDTO AddNewMember(MemberRequestDTO memberRequest);
        MemberResponseDTO UpdateExistingBook(MemberRequestDTO memberRequest);
        bool RemoveBook(int id);
        MemberResponseDTO FindMemberByName(string name);
    }
}
