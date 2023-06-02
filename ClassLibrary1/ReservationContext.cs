using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class ReservationContext : IDb<Reservation, int>
    {
        private readonly RestaurantDbContext dbContext;
        public ReservationContext(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Reservation item)
        {
            try
            {
                dbContext.Reservations.Add(item);
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
                Reservation reservation = dbContext.Reservations.Find(id);
                dbContext.Reservations.Remove(reservation);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Reservation> ReadAll()
        {
            try
            {
                return dbContext.Reservations.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public Reservation ReadOne(int id)
        {
            try
            {
                return dbContext.Reservations.Find(id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update(Reservation item)
        {
            try
            {
                Reservation reservation = dbContext.Reservations.Find(item.ReservationId);
                dbContext.Entry(reservation).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
