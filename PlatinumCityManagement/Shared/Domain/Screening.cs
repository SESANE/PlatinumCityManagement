using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Screening : BaseDomainModel
    {
        public int Price { get; set; }
        public DateTime Showtime { get; set; }
        public virtual Hall? Hall { get; set; }
        
        //public virtual Movie? Movie { get; set; }

    }
}
