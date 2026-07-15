using Microsoft.AspNetCore.Mvc;

namespace CanblePop.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
