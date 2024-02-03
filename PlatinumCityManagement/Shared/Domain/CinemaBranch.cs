using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class CinemaBranch : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int HallQuantity { get; set; }
    }
}
