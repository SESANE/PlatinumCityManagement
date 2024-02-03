using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MoviesEndpoint = $"{Prefix}/movies";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
		public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
		public static readonly string CinemaBranchesEndpoint = $"{Prefix}/cinemaBranches";
		public static readonly string HallsEndpoint = $"{Prefix}/halls";
		public static readonly string ScreeningsEndpoint = $"{Prefix}/screenings";
		public static readonly string SeatsEndpoint = $"{Prefix}/seats";
	}
}
