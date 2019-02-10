using Microsoft.AspNet.Identity.EntityFramework;
using Shop.DAL.Identity.Entities;

namespace Shop.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString)
        {
        }
    }
}
