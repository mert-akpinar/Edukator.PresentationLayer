using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MemberLayoutController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<PartialViewResult> MemberSidebarPartial()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);    
            ViewBag.name = values.Name;
            ViewBag.Surname = values.Surname;
            return PartialView();
        }
    }
}
