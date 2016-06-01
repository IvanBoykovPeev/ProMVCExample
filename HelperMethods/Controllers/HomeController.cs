using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "New York", "London", "Paris" };
            string message = "This is an HTML element: <input>";
            return View((object)message);
        }
    }
}