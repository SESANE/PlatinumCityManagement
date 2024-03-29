﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatinumCityManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class Pleaseeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CinemaBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HallQuantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    MembershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Review = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreeningQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    CinemaBranchId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Halls_CinemaBranches_CinemaBranchId",
                        column: x => x.CinemaBranchId,
                        principalTable: "CinemaBranches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformanceRating = table.Column<int>(type: "int", nullable: false),
                    CinemaBranchId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_CinemaBranches_CinemaBranchId",
                        column: x => x.CinemaBranchId,
                        principalTable: "CinemaBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Showtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatTaken = table.Column<bool>(type: "bit", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "b6ae90e2-c81c-444d-8aae-6fc935b403f2", null, "Customer", "CUSTOMER" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c8e4151-99c2-4a65-9cf1-53ade661a38e", 0, "60881461-e173-4329-8267-e0d728ef192a", "tan@gmail.com", false, "Yan", "Teo", false, null, "TAN@GMAIL.COM", "TAN@GMAIL.COM", "AQAAAAIAAYagAAAAELcthhWvTFkpe8D6DqK0t0TNMy+PAhfU5IBWlhYxjzoDtkh59ho826hBkbLe1lbKQQ==", null, false, "529999d5-6ea5-4c9b-9c3c-d408692d1d91", false, "tan@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "339f9ef4-8116-4017-a318-2c53c3c49f8e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMBr/7mjnaCP9ASNGHLhoE4Ot4BVus/D8UgKUc7IM5/w0kNBli6NcRAx1M5fyjxviQ==", null, false, "287a0ccb-eef5-4b4d-8777-5eb0c5362202", false, "admin@localhost.com" },
                    { "c0ffdf85-d757-4286-8e84-b16117b416c8", 0, "14850512-390f-40e4-8607-792eb4783f06", "lee@gmail.com", false, "Johnny", "Lee", false, null, "LEE@GMAIL.COM", "LEE@GMAIL.COM", "AQAAAAIAAYagAAAAECaxCGk/WDe5TFnYJCoFNOE+aOrAjVJC3jJbrptvPBhenimHrpW4btytLP2gDH2Geg==", null, false, "8ccab79c-7138-485c-8e09-52489f38959f", false, "lee@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CinemaBranches",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "HallQuantity", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Tampines", "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(234), 9, "Platinum City Tampines", "System" },
                    { 2, "Bedok", "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(238), 10, "Platinum City Bedok", "System" },
                    { 3, "Jewel Changi Airport", "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(242), 8, "Platinum City Jewel", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DOB", "DateCreated", "DateUpdated", "EmailAddress", "MembershipType", "Name", "Points", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "707 Tampines Street 71 #09-20, 520707", "89220951", null, new DateTime(2005, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lee@gmail.com", "Platinum", "Johnny Lee", 133, null },
                    { 2, "707 Geylang Street 71 #02-20, 520707", "89235451", null, new DateTime(2002, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tan@gmail.com", "Platinum", "Tan", 192, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "MovieDescription", "Poster", "Rating", "Review", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Brie Larson, Teyonah Parris, Iman Vellani", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 45mins", "Brie Larson, Iman Vellani, and director Nia DaCosta surprised fans across the country. Carol Danvers AKA Captain Marvel has reclaimed her identity from the tyrannical Kree and taken revenge on the Supreme Intelligence. But unintended consequences see Carol shouldering the burden of a destabilized universe.", "/posters/marvels.jpeg", "5.0", "okok", "The Marvels", null },
                    { 2, "Margot Robbie, Ryan Gosling", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 33mins", "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.", "/posters/barbie.jpg", "3.9", "meh", "Barbie", null },
                    { 3, "Timothee Chalemet", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 30mins", "With dreams of opening a shop in a city renowned for its chocolate, a young and poor Willy Wonka discovers that the industry is run by a cartel of greedy chocolatiers.", "/posters/wonka.jpg", "2.0", "eeee", "Wonka", null },
                    { 4, "David S. Goyer", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 13mins", "Blade, now a wanted man by the FBI, must join forces with the Nightstalkers to face his most challenging enemy yet: Dracula.", "/posters/blade3.jpg", "2.3", "ok", "Blade", null },
                    { 5, "Alexander Skarsgård, Millie Bobbie Brown", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 33mins", "The epic next chapter in the cinematic Monsterverse pits two of the greatest icons in motion picture history against each other--the fearsome Godzilla and the mighty Kong--with humanity caught in the balance.", "/posters/godzillaa.jpg", "2.3", "ok only", "Godzilla", null },
                    { 6, "Gong Yoo, Jung Yumi, Ma Dong Seok", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 43mins", "While a zombie virus breaks out in South Korea, passengers struggle to survive on the train from Seoul to Busan.", "/posters/traintobusan.jpg", "4.8", "nice", "Train To Busan", null },
                    { 7, "Albert Brooks", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 23mins", "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.", "/posters/nemo.jpg", "4.9", "amazing", "Nemo", null },
                    { 8, "Ryan Reynolds", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1h 54mins", "A wisecracking mercenary gets experimented on and becomes immortal yet hideously scarred, and sets out to track down the man who ruined his looks.", "/posters/deadpool.jpg", "3.9", "not bad", "Deadpool", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b6ae90e2-c81c-444d-8aae-6fc935b403f2", "1c8e4151-99c2-4a65-9cf1-53ade661a38e" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "c0ffdf85-d757-4286-8e84-b16117b416c8" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "CinemaBranchId", "CreatedBy", "DateCreated", "DateUpdated", "Name", "ScreeningQuality", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 100, 1, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(600), "1", "IMAX", "System" },
                    { 2, 90, 2, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(603), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(604), "1", "DOLBY ATMOS", "System" },
                    { 3, 80, 3, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(607), "1", "HD", "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "CinemaBranchId", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "Name", "PerformanceRating", "Role", "UpdatedBy" },
                values: new object[] { 1, "499B Tampines Ave 9, #08-238, Singapore 522499", 1, "81207097", "System", new DateTime(2024, 2, 6, 15, 18, 5, 508, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 2, 6, 15, 18, 5, 508, DateTimeKind.Local).AddTicks(9842), "John@platinumcity.com", "John", 5, "Manager", "System" });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "HallId", "MovieId", "Price", "Showtime", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(972), 1, 1, 10, new DateTime(2024, 2, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(978), 2, 1, 12, new DateTime(2024, 2, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(981), 3, 1, 15, new DateTime(2024, 2, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ScreeningId", "SeatNo", "SeatTaken", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1350), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1354), 1, "A1", false, "System" },
                    { 2, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1365), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1366), 1, "A2", false, "System" },
                    { 3, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1368), 1, "A3", false, "System" },
                    { 4, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1370), 1, "A4", false, "System" },
                    { 5, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1394), 1, "A5", false, "System" },
                    { 6, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1429), 1, "A6", false, "System" },
                    { 7, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1431), 1, "A7", false, "System" },
                    { 8, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1433), 1, "A8", false, "System" },
                    { 9, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1436), 1, "A9", true, "System" },
                    { 10, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1438), 1, "A10", true, "System" },
                    { 21, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1441), 2, "A1", false, "System" },
                    { 22, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1443), 2, "A2", false, "System" },
                    { 23, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1445), 2, "A3", false, "System" },
                    { 24, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1447), 2, "A4", false, "System" },
                    { 25, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1450), 2, "A5", false, "System" },
                    { 26, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1452), 2, "A6", false, "System" },
                    { 27, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1454), 2, "A7", false, "System" },
                    { 28, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1456), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1456), 2, "A8", false, "System" },
                    { 29, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1458), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1459), 2, "A9", true, "System" },
                    { 30, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1460), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1461), 2, "A10", true, "System" },
                    { 31, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1463), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1463), 3, "A1", false, "System" },
                    { 32, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1465), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1465), 3, "A2", false, "System" },
                    { 33, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1467), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1468), 3, "A3", false, "System" },
                    { 34, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1469), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1470), 3, "A4", false, "System" },
                    { 35, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1472), 3, "A5", false, "System" },
                    { 36, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1474), 3, "A6", false, "System" },
                    { 37, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1476), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1477), 3, "A7", false, "System" },
                    { 38, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1479), 3, "A8", false, "System" },
                    { 39, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1481), 3, "A9", true, "System" },
                    { 40, "System", new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1483), new DateTime(2024, 2, 6, 15, 18, 5, 509, DateTimeKind.Local).AddTicks(1484), 3, "A10", true, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ScreeningId",
                table: "Bookings",
                column: "ScreeningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SeatId",
                table: "Bookings",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_StaffId",
                table: "Bookings",
                column: "StaffId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_CinemaBranchId",
                table: "Halls",
                column: "CinemaBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_HallId",
                table: "Screenings",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ScreeningId",
                table: "Seats",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CinemaBranchId",
                table: "Staffs",
                column: "CinemaBranchId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "CinemaBranches");
        }
    }
}
