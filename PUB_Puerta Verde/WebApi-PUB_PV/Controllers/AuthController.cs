using Microsoft.AspNetCore.Mvc;

namespace WebApi_PUB_PV.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
