using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Hall : BaseDomainModel
    {
        public string? ScreeningQuality { get; set; }
        public string? Type { get; set; }
        public int Capacity { get; set; }
        public int SeatNumber { get; set; }
        public bool SeatTaken { get; set; }
        public virtual CinemaBranch? CinemaBranch { get; set; }

    }
}
