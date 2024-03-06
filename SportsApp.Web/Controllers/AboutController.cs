using Microsoft.AspNetCore.Mvc;

namespace SportsApp.Web.Controllers {
    public class AboutController : Controller {

        [Route("/About")]
        public IActionResult Index() {
            return View();
        }
    }
}
