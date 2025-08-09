using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceImpl
{
    public class MemberService : IMemberService
    {
        public MemberResponseDTO AddNewMember(MemberRequestDTO memberRequest)
        {
            throw new NotImplementedException();
        }

        public MemberResponseDTO FindMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<MemberResponseDTO> GetAllMembers(MemberRequestDTO memberRequest)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(int id)
        {
            throw new NotImplementedException();
        }

        public MemberResponseDTO UpdateExistingBook(MemberRequestDTO memberRequest)
        {
            throw new NotImplementedException();
        }
    }
}
