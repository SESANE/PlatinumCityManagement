using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlatinumCityManagement.Shared.Domain
{
    public class Screening : BaseDomainModel, IValidatableObject
    {
        public int? Price { get; set; }
        public DateTime Showtime { get; set; }
        public int? HallId { get; set; }
        public virtual Hall? Hall { get; set; }
		public int? MovieId { get; set; }
		public virtual Movie? Movie { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (Showtime <= DateTime.Now)
			{
				yield return new ValidationResult("Showtime must be greater than Current Time", new[] { "Showtime" });
			}

			if (Price > 50)
			{
				yield return new ValidationResult("Invalid Price", new[] { "Price" });
			}
		}
	}

}
