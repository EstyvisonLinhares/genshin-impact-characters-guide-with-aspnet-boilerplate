using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using GenshinImpactGuider.Controllers;

namespace GenshinImpactGuider.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GenshinImpactGuiderControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
