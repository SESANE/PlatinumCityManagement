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
        public string BookingType { get; set; }
        public double TotalPrice { get; set; }
        public int SeatQty { get; set; }
        public string SeatNo { get; set; }
        public DateTime BookingDateTime { get; set; }
        
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

      

    }
}

