using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NmtLesson05Model.Models;

namespace NmtLesson05Model.Controllers
{
    public class NmtHomeController : Controller
    {
        private readonly ILogger<NmtHomeController> _logger;

        public NmtHomeController(ILogger<NmtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NmtIndex()
        {
            return View();
        }

        public IActionResult NmtAbout()
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
