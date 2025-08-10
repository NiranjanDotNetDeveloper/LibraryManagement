using Azure.Core;
using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementUI.Controllers
{
    [Route("[controller]")]
    public class MemberController : Controller
    {
        private readonly IMemberService memberService;
        public MemberController(IMemberService memberService)
        {
            this.memberService = memberService;
        }
        [Route("getAllMembers")]
        public IActionResult GetAllMembers()
        {
            var response = memberService.GetAllMembers();
            return View(response);
        }
        [Route("AddNewMembers")]
        [HttpGet]
        public IActionResult AddNewMembers()
        {
            MemberResponseDTO request = new MemberResponseDTO();
            return View(request);
        }
        [Route("AddNewMembers")]
        [HttpPost]
        public IActionResult AddNewMembers(MemberRequestDTO request)
        {
            var response = memberService.AddNewMember(request);
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return View(response);
            }
        }
        [Route("UpdateMembers/{name}")]
        [HttpGet]
        public IActionResult UpdateMembers(string name)
        {
            var member = memberService.FindMemberByName(name);
            return View(member);
        }
        [Route("UpdateMembers/{name}")]
        [HttpPost]
        public IActionResult UpdateMembers(string name,MemberRequestDTO response)
        {
            if (ModelState.IsValid)
            {
                memberService.UpdateExistingMember(name, response);
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                return View(response);
            }
        }
        [Route("RemoveMember/{name}")]
        [HttpGet]
        public IActionResult RemoveMember(string name)
        {
            var member = memberService.RemoveMember(name);
            if(member)
                {
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                return BadRequest("Member not found or could not be removed.");
            }
        }
    }
}
