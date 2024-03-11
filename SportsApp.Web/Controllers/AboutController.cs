using Microsoft.AspNetCore.Mvc;

namespace SportsApp.Web.Controllers {
    [Route("/About")]
    public class AboutController : Controller {

        [Route("/")]
        public IActionResult Index() {
            return View();
        }
    }
}
