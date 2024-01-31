using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? ContactNumber { get; set; }
        public int Points { get; set; }
        public string? MembershipType { get; set; }

    }
}