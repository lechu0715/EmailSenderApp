using EmailSenderApp.Models.Domains;
using EmailSenderRe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmailSenderApp.Models.Repositories
{
    public class EmailRepository
    {
        public async Task SendMessage(EmailModel emailModel)
        {
            EmailParams emailParams = new EmailParams()
            {
                HostSmtp = "smtp.gmail.com",
                EnableSsl = true,
                Port = 587,
                SenderEmail = $"{emailModel.From}",
                SenderEmailPassword = "uskkwanygpbmkkrx",
                SenderName = $"{emailModel.From}"
            };

            Email email = new Email(emailParams);

            await email.Send(emailModel.Title, emailModel.Text, emailModel.To);
        }
    }
}