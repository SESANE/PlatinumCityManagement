using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlatinumCityManagement.Shared.Domain
{
    public class CinemaBranch : BaseDomainModel, IValidatableObject
	{
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
		public string? Name { get; set; }
        public string? Address { get; set; }
		[Required]
		public int? HallQuantity { get; set; }
		public virtual Staff? Staff { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			//throw new NotImplementedException();

			if (HallQuantity != null)
			{
				if (HallQuantity > 16)
				{
					yield return new ValidationResult("Hall Quantity cannot be greater than 15", new[] { "HallQuantity" });
				}
			}
		}
	}
}
