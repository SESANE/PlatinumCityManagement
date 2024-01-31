using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? ContactNumber { get; set; }
        public string? Role { get; set; }
        public int PerformanceRating { get; set; }
		public int CinemaBranchId {  get; set; }
		public virtual CinemaBranch? CinemaBranch { get; set; }
        
    }
}
