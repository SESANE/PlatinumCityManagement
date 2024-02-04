using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
		public string? Name { get; set; }
        public string? Address { get; set; }
		[Required]
		[DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
		[EmailAddress]
		public string? EmailAddress { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
		public string? ContactNumber { get; set; }
		[Required]
        public string? Role { get; set; }
        public int PerformanceRating { get; set; }
		public int CinemaBranchId {  get; set; }
		public virtual CinemaBranch? CinemaBranch { get; set; }
        
		
		
        
    }
}
