using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmailSenderApp.Models.Domains
{
    public class EmailModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Nadawca")]
        public string From { get; set; } 

        [Required]
        [Display(Name = "Odbiorca")]
        public string To { get; set; }

        public string Text { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }



        public ApplicationUser User { get; set; }
    }
}