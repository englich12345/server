using CoreApp.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}