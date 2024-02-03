using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Shared.Domain
{
	public class Seat : BaseDomainModel
	{
		public string? SeatNo { get; set; }
		public bool SeatTaken { get; set; }
		public int HallId { get; set; }
		public virtual Hall? Hall { get; set; }

	}
}
