using Microsoft.AspNetCore.Antiforgery;
using vue_abp_demo.Controllers;

namespace vue_abp_demo.Web.Host.Controllers
{
    public class AntiForgeryController : vue_abp_demoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
