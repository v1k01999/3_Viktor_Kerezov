using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Reservation
    {
        public Reservation()
        {

        }
        [Key]
        public int ReservationId { get; set; }
        [Required, Range(1, 1000)]
        public int RoomsCount { get; set; }
        [Required, Range(1, 100)]
        public int DaysCount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, Range(0, 10000)]
        public decimal Price { get; set; }
    }
}
