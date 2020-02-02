using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    public class ContactController : Controller
    {
        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Client)]

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
