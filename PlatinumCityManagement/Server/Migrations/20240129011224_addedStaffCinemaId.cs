using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatinumCityManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedStaffCinemaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_CinemaBranches_CinemaBranchId",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaBranchId",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "Screenings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc5a6d55-8040-4ea6-8647-4eefb05a4208", "AQAAAAIAAYagAAAAEKG5VKA59zMaQUTyzjxX+LANLvqdA7yw6Os979cIi7vNYlGM5SWLFcRcXJC0jLksVQ==", "2a5497f5-8bbb-4490-a6fd-39a960e460d2" });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 9, 12, 23, 814, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 1, 29, 9, 12, 23, 814, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CinemaBranchId", "DateCreated", "DateUpdated" },
                values: new object[] { 1, new DateTime(2024, 1, 29, 9, 12, 23, 814, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 1, 29, 9, 12, 23, 814, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_CinemaBranches_CinemaBranchId",
                table: "Staffs",
                column: "CinemaBranchId",
                principalTable: "CinemaBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_CinemaBranches_CinemaBranchId",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaBranchId",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "Screenings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f142c84-4d79-4eb1-b3b8-63d71847bfce", "AQAAAAIAAYagAAAAEF0Thi9Kv5ZSGQXzqOlIspY8y+372VEShLDYsSEGQRcBnfL28dJ5w9vhPuD8vIx7oA==", "97b846ea-5b12-4d73-95fa-2f10d5d633a7" });

            migrationBuilder.UpdateData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CinemaBranchId", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Halls_HallId",
                table: "Screenings",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_CinemaBranches_CinemaBranchId",
                table: "Staffs",
                column: "CinemaBranchId",
                principalTable: "CinemaBranches",
                principalColumn: "Id");
        }
    }
}
