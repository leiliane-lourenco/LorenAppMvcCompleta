using Microsoft.AspNetCore.Mvc;

namespace Loren.Api.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
