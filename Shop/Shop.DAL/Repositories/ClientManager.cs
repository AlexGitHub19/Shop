using Shop.DAL.EF;
using Shop.DAL.Interfaces;

namespace Shop.DAL.Repositories
{
    class ClientManager : IClientManager
    {
        public ApplicationContext Database { get; set; }
        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create()
        {
            // Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}

