using EmailSenderApp.Models.Domains;
using EmailSenderApp.Models.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmailSenderApp.Controllers
{
    

    [Authorize]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateEmail()
        {
            var userEmail = User.Identity.Name;

            var vm = new EditEmailViewModel()
            {
                Heading = "Nowa Wiadomość",
                EmailModel = new EmailModel()
                {
                    From = userEmail
                }
            };

            return View(vm);
        }

        /*[HttpPost]
        public async Task<ActionResult> SendEmail()
        {

        }*/

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Aplikacja do wysyłania E-maili.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}