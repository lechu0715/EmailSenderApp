using System.Data.Entity;
using EmailSenderApp.Models.Domains;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EmailSenderApp.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<EmailModel> Emails { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}