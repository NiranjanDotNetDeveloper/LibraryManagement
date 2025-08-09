using LibraryInfra.RepositoryImpl;
using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementCore.ServiceImpl
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository  memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }
        public MemberResponseDTO AddNewMember(MemberRequestDTO memberRequest)
        {
            var response=memberRepository.AddNewMember(memberRequest.ConvertMemberRequestDTOToMember());
            return response.ConvertMemberResponseDTOToMember();
        }

        public MemberResponseDTO FindMemberByName(string name)
        {
            var response= memberRepository.FindMemberByName(name);
            return response.ConvertMemberResponseDTOToMember();
        }

        public List<MemberResponseDTO> GetAllMembers()
        {
            var response = memberRepository.GetAllMembers();
            return response.Select(x => x.ConvertMemberResponseDTOToMember()).ToList();

        }

        public bool RemoveBook(int id)
        {
           return memberRepository.RemoveBook(id);
          
        }

        public MemberResponseDTO UpdateExistingBook(int id, MemberRequestDTO memberRequest)
        {
            var response = memberRepository.UpdateExistingBook(id,memberRequest.ConvertMemberRequestDTOToMember());
            return response.ConvertMemberResponseDTOToMember();
        }
    }
}
