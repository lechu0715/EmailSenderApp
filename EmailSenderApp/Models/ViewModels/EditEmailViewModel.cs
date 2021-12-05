using EmailSenderApp.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSenderApp.Models.ViewModels
{
    public class EditEmailViewModel
    {
        public EmailModel EmailModel { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string Heading { get; set; }
    }
}