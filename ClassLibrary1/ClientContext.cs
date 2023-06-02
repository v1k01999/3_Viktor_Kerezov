using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClientContext : IDb<Client, int>
    {
        private readonly RestaurantDbContext dbContext;
        public ClientContext(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Client item)
        {
            try
            {
                dbContext.Clients.Add(item);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                Client client = dbContext.Clients.Find(id);
                dbContext.Clients.Remove(client);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Client> ReadAll()
        {
            try
            {
                return dbContext.Clients.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public Client ReadOne(int id)
        {
            try
            {
                return dbContext.Clients.Find(id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update(Client item)
        {
            try
            {
                Client client = dbContext.Clients.Find(item.ClientId);
                dbContext.Entry(client).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
