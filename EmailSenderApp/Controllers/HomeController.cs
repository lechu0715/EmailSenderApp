using EmailSenderApp.Models.Domains;
using EmailSenderApp.Models.Repositories;
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
        EmailRepository _emailRepository = new EmailRepository();
        Repository _repository = new Repository();

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

        [HttpPost]
        public async Task<ActionResult> SendEmail(EmailModel emailModel)
        {
            emailModel.UserId = User.Identity.GetUserId();

            await _emailRepository.SendMessage(emailModel);

            _repository.AddEmail(emailModel);

            return View();
        }

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