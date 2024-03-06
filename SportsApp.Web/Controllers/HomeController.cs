using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Controllers {
    public class HomeController : Controller {

        [Route("/")]
        public async Task<IActionResult> Index() {

            return View();
        }
    }
}
