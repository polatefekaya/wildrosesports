using Microsoft.AspNetCore.Mvc;

namespace SportsApp.Web.Controllers {
    public class SupportController : Controller {
        [Route("/Support")]
        public IActionResult Index() {
            return View();
        }
    }
}
