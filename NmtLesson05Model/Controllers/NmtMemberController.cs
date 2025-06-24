using Microsoft.AspNetCore.Mvc;
using NmtLesson05Model.Models.DataModels;

namespace NmtLesson05Model.Controllers
{
    public class NmtMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NmtGetMember()
        {
            var nmtMember = new NmtMember();
            nmtMember.NmtMemberID = Guid.NewGuid().ToString();
            nmtMember.NmtUserName = "AniKmizu2262";
            nmtMember.NmtFullName = "Nguyễn Mạnh Tuấn";
            nmtMember.NmtPassword = "pass123";
            nmtMember.NmtEmail = "nguyenmanhtuantuan58@gmail.com";

            ViewBag.nmtMember = nmtMember;
            return View();
        }

    }
}
