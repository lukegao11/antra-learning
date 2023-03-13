using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
