using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        [Required(ErrorMessage = "Booking type is required")]
        [RegularExpression("Student|Adult", ErrorMessage = "Invalid Booking Type")]
        public string BookingType { get; set; }
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int ScreeningId { get; set; }
        public virtual Screening? Screening { get; set; }
        public int SeatId { get; set; }
        public virtual Seat? Seat { get; set; }




    
    }
}

