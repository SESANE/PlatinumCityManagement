namespace PlatinumCityManagement.Client.Static
{
	public static class Endpoints
	{
		private static readonly string Prefix = "api";

		public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
		public static readonly string CinemaBranchesEndpoint = $"{Prefix}/cinemaBranches";
		public static readonly string HallsEndpoint = $"{Prefix}/halls";
		public static readonly string ScreeningsEndpoint = $"{Prefix}/screenings";
	}
}
