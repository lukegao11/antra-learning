using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class SubmissionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
