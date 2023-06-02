using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Restaurant
    {
        public Restaurant()
        {

        }
        [Key]
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public List<Reservation> Reservations { get; set; }
        public double Income { get; set; }
    }
}
