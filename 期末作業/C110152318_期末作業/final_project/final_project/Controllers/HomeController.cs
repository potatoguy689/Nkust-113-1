using System.Diagnostics;
using final_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated) // �ˬd�Τ�O�_�n�J
            {
                return RedirectToAction("StudentProgress", "Enrollment"); // �w�n�J�A�����ڪ��ҵ{�i��
            }
            return View(); // �p�G���n�J�A����w�ﭶ��
        }


        public IActionResult Privacy()
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
