using Microsoft.AspNetCore.Mvc;

namespace SportsApp.Web.Controllers {
    [Route("/Support")]
    public class SupportController : Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }
    }
}
