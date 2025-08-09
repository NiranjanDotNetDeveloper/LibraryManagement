using LibraryCore.Domain.Entity;
using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public interface IMemberRepository
    {
        List<Member> GetAllMembers();
        Member AddNewMember(Member memberRequest);
        Member UpdateExistingBook(int id,Member memberRequest);
        bool RemoveBook(int id);
        Member FindMemberByName(string name);
    }
}
