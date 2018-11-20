using Myfactory.SIT.app.Models;

using System.Web.Mvc;

namespace Myfactory.SIT.app.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidaUser([Bind(Include ="Email, Senha")] UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}