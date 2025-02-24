using Microsoft.AspNetCore.Mvc;

namespace SessionExample.Controllers
{
    public class CounterController : Controller
    {
        private const string SessionKey = "VisitCount";

        public IActionResult Index()
        {
            int count = HttpContext.Session.GetInt32(SessionKey) ?? 0;
            count++;
            HttpContext.Session.SetInt32(SessionKey, count);

            ViewBag.VisitCount = count;
            return View();
        }
    }
}
