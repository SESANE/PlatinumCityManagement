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
        [StringLength(100, ErrorMessage = "Name must be between 2 and 80 characters", MinimumLength = 2)]
        public string? Name { get; set; }

        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Address must be between 10 and 150 characters", MinimumLength = 10)]
        public string? Address { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailAddress { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string? ContactNumber { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Points must be a non-negative number")]
        public int Points { get; set; }

        [Required(ErrorMessage = "Membership type is required")]
        [RegularExpression("Basic|Silver|Gold|Platinum", ErrorMessage = "Invalid Membership Type")]
        public string? MembershipType { get; set; }

        public virtual Booking? Booking { get; set; }
    }
}