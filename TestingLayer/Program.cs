using BusinessLayer;
using DataLayer;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientContext clientsDbContext = new ClientContext(new RestaurantDbContext());
            ReservationContext reservationsDbContext = new ReservationContext(new RestaurantDbContext());

            Client client = new Client();
            client.ClientId = 1;
            client.Name = "Ivan";
            client.Age = 54;
            client.Reservations = new List<Reservation>();
            clientsDbContext.Create(client);

            Reservation reservation = new Reservation();
            reservation.ReservationId = 1;
            reservation.RoomsCount = 2;
            reservation.DaysCount = 7;
            reservation.Date = DateTime.UtcNow;
            reservation.Price = 1000;
            reservationsDbContext.Create(reservation);
        }
    }
}