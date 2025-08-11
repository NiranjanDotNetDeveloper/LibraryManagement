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
                TempData["SuccessMessage"] = "Member added successfully!";
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                TempData["ErrorMessage"] = "Failed to add Member!";
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
                TempData["SuccessMessage"] = "Member Updated successfully!";
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                TempData["ErrorMessage"] = "Failed to Update the Member!";
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
                TempData["SuccessMessage"] = "Member removed successfully!";
                return RedirectToAction("GetAllMembers");
            }
            else
            {
                TempData["ErrorMessage"] = "Failed to remove the Member!";
                return BadRequest("Member not found or could not be removed.");
            }
        }
    }
}
