using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatinumCityManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50526fc7-19c8-499b-884c-dc98dd059614", "AQAAAAIAAYagAAAAEKQg1zVuCv1tb3W4IrA6GLiUibOE7JUgBWWkSzdtYZ3EH/MdP9kpXehlPqgqEyGrGA==", "fe2f5830-2946-4bac-b731-f1febccad45b" });

            migrationBuilder.InsertData(
                table: "CinemaBranches",
                columns: new[] { "Id", "Address", "HallQuantity", "Name" },
                values: new object[] { 1, "Tampines", 9, "Platinum City Tampines" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CinemaBranches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b20e5cc7-3cf0-4e72-bfd0-f37e4986ed98", "AQAAAAIAAYagAAAAEGrmELlfpS4vj/8RWI4Vi9tu82vES2UjG/7V+7hwjG3W/yEQZbuqhq5nx5Y+/aaxvQ==", "d8ee22dd-335a-4cc8-b0b8-459c07b0ccc9" });
        }
    }
}
