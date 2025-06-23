using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nmt_Lesson03.Models; // Đổi namespace Models nếu cần

namespace Nmt_Lesson03.Controllers // Đổi namespace Controllers
{
    public class NmtHomeController : Controller // Đổi tên class
    {
        private readonly ILogger<NmtHomeController> _logger; // Đổi kiểu logger

        public NmtHomeController(ILogger<NmtHomeController> logger) // Đổi constructor
        {
            _logger = logger;
        }

        public IActionResult NmtIndex() // Đổi tên action
        {
            return View();
        }

        public IActionResult NmtAbout() // Đổi tên action
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
