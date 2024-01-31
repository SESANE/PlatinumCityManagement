using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatinumCityManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedStaffs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Screenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Screenings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Screenings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Screenings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Halls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Halls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Halls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CinemaBranches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CinemaBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "CinemaBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CinemaBranches",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9684), new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9685), "System" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 1, 29, 0, 31, 48, 729, DateTimeKind.Local).AddTicks(9441), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CinemaBranches");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CinemaBranches");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "CinemaBranches");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CinemaBranches");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50526fc7-19c8-499b-884c-dc98dd059614", "AQAAAAIAAYagAAAAEKQg1zVuCv1tb3W4IrA6GLiUibOE7JUgBWWkSzdtYZ3EH/MdP9kpXehlPqgqEyGrGA==", "fe2f5830-2946-4bac-b731-f1febccad45b" });
        }
    }
}
