using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}