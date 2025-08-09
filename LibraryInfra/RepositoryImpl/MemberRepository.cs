using LibraryCore.Domain.Entity;
using LibraryInfra.SqlConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DbContextImpl _dbContext;
        public MemberRepository(DbContextImpl dbContext)
        {
            _dbContext = dbContext;
        }
        public Member AddNewMember(Member memberRequest)
        {
            Member member = new Member();
            member.Name=memberRequest.Name;
            member.Email = memberRequest.Email;
            member.MembershipDate = memberRequest.MembershipDate;
            member.MembershipType = memberRequest.MembershipType;
            _dbContext.Members.Add(member);
            _dbContext.SaveChanges();
            return member;
        }

        public Member FindMemberByName(string name)
        {
            Member member = _dbContext.Members.FirstOrDefault(x => x.Name == name);
            return member;
        }

        public List<Member> GetAllMembers(Member memberRequest)
        {
            return _dbContext.Members.ToList();
        }

        public bool RemoveBook(int id)
        {
            Member member = _dbContext.Members.FirstOrDefault(x => x.MemoberId == id);
            if (member == null)
                return false;
            else
            {
                _dbContext.Members.Remove(member);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public Member UpdateExistingBook(int id,Member memberRequest)
        {
            Member member = _dbContext.Members.FirstOrDefault(x=>x.MemoberId==id);
            member.Name = memberRequest.Name;
            member.Email = memberRequest.Email;
            member.MembershipDate = memberRequest.MembershipDate;
            member.MembershipType = memberRequest.MembershipType;
            _dbContext.Members.Update(member);
            _dbContext.SaveChanges();
            return member;
        }
    }
}
