using Microsoft.AspNetCore.Mvc;

namespace SiteWebChamados.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
