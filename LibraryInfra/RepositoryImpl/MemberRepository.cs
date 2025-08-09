using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class MemberRepository : IMemberRepository
    {
        public Member AddNewMember(Member memberRequest)
        {
            throw new NotImplementedException();
        }

        public Member FindMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAllMembers(Member memberRequest)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(int id)
        {
            throw new NotImplementedException();
        }

        public Member UpdateExistingBook(Member memberRequest)
        {
            throw new NotImplementedException();
        }
    }
}
