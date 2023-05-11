using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class SweatAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
