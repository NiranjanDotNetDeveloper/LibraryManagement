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
        Member UpdateExistingMember(string name,Member memberRequest);
        bool RemoveMember(string name);
        Member FindMemberByName(string name);
    }
}
