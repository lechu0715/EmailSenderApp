using EmailSenderApp.Models;
using EmailSenderApp.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSenderApp
{
    public class Repository
    {
        public void AddEmail(EmailModel emailModel)
        {
            using (var context = new ApplicationDbContext())
            {
                context.EmailModels.Add(emailModel);

                context.SaveChanges();
            }
        }

        public string TakeApplicationPassword(string UserId)
        {
            using (var context = new ApplicationDbContext())
            {
                var applicationPassword = context.Users.Where(x => x.Id == UserId)
                    .Select(x => x.ApplicationPassword);

                return applicationPassword.Single();
            }
        }
    }
}