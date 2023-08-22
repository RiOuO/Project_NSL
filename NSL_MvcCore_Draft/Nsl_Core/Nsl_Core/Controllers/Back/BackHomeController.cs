using Microsoft.AspNetCore.Mvc;
using Nsl_Core.Models.Infra;

namespace NSL_html.Controllers.Back
{
    [TypeFilter(typeof(AdminVerify))]
    public class BackHomeController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();//不顯示Layout
        }

        public IActionResult Login()
        {
            return PartialView();
        }
		public IActionResult Signout()
		{
			HttpContext.Response.Cookies.Delete("Login");
			TempData.Remove("Login");
			return RedirectToAction("Index","NSL");
		}
	}
}
