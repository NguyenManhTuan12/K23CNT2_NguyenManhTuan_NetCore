using Microsoft.AspNetCore.Mvc;

namespace NmtLesson02.Controllers
{
    public class NmtProductController : Controller
    {
        public IActionResult NmtIndex()
        {
            ViewData["messageData"] = "Dữ liệu từ viewData";
            ViewBag.messageData = "Dữ liệu từ viewBag";
            TempData["messageData"] = "Dữ liệu từ tempData";
            return View();
        }
    }
}
