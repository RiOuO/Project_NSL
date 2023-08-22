using Microsoft.AspNetCore.Mvc;
using Nsl_Core.Models.Infra;

namespace NSL_html.Controllers.Back
{
    [TypeFilter(typeof(AdminVerify))]
    public class BackReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
