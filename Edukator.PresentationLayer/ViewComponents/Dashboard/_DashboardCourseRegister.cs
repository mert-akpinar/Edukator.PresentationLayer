using Edukator.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{    
    public class _DashboardCourseRegister : ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public _DashboardCourseRegister(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseRegisterService.TCourseRegisterListWithCoursesAndUsers();
            return View(values);
        }
    }
}
