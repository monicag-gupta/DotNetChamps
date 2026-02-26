using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Registration r)
        {
            if (ModelState.IsValid)
            {
                return Content("Thank You for Registration "
                    + r.Name + ", "
                    + r.Email + ", "
                    + r.Phone);
            }

            return View(r);
        }
    }
}
