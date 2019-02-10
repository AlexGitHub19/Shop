using Microsoft.AspNet.Identity.EntityFramework;
using Shop.DAL.EF;
using Shop.DAL.Identity;
using Shop.DAL.Identity.Entities;
using Shop.DAL.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.DAL.Repositories
{
    public class IdentityUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;

        public IdentityUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            UserManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            RoleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
        }

        public ApplicationUserManager UserManager { get; private set; }

        public ApplicationRoleManager RoleManager { get; private set; }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    UserManager.Dispose();
                    RoleManager.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}

