using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet] // attribute 
        public IActionResult Index()
        {
            //return all tyhe joibs so that the candiates can apply the them,
            return View();
        }



        [HttpGet]
        //return the job detailed info
        public IActionResult Details( int id) {

            return View();
        }


        [HttpPost]
        //Authenticated and User should have role for creating new job
        //HR/Manager
        public IActionResult Create() { 
            //take the information from the view asnd save to DB
            return View();
        
        }
    }
}
