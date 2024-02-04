using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
	public class Seat : BaseDomainModel
	{
        [Required(ErrorMessage = "The seat number is required.")]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "The seat number must be alphanumeric.")]
        public string? SeatNo { get; set; }
        public bool SeatTaken { get; set; }
		public int HallId { get; set; }
		public virtual Hall? Hall { get; set; }

	}
}
