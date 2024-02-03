using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Hall : BaseDomainModel, IValidatableObject
	{
		public string? Name { get; set; }
		public string? ScreeningQuality { get; set; }
        public int? Capacity { get; set; }
        public int? CinemaBranchId { get; set; }
        public virtual CinemaBranch? CinemaBranch { get; set; }
		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			//throw new NotImplementedException();

			if (Capacity != null)
			{
				if (Capacity > 100)
				{
					yield return new ValidationResult("Capacity cannot be greater than 100", new[] { "HallQuantity" });
				}
			}
		}

	}
}
