using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatinumCityManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.InsertData(
                table: "CinemaBranches",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "HallQuantity", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "Bedok", "System", new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2259), 10, "Platinum City Bedok", "System" },
                    { 3, "Jewel Changi Airport", "System", new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2262), 8, "Platinum City Jewel", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 895, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 2, 3, 22, 31, 18, 895, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "CinemaBranchId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "ScreeningQuality", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, 90, 2, "System", new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(298), "1", "DOLBY ATMOS", "System" },
                    { 3, 80, 3, "System", new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(301), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(301), "1", "HD", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4968), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4974), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4982), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 2, 3, 17, 59, 6, 317, DateTimeKind.Local).AddTicks(3945) });
        }
    }
}
