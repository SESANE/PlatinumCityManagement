using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatinumCityManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class edit_navigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1464), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1246), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1252), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 2, 4, 11, 28, 47, 708, DateTimeKind.Local).AddTicks(745) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(301), new DateTime(2024, 2, 3, 22, 31, 18, 896, DateTimeKind.Local).AddTicks(301) });

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
        }
    }
}
