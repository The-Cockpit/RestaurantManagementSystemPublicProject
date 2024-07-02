using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class fuckingworkplease : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Weeks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeeklyComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekStatus = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.ID);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Shifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsTicked = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WeekId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shifts_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shifts_Weeks_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Weeks",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsManager", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "216b9c39-c4a0-4c0d-ac5c-4c487a8452f0", "waiter1@example.com", true, "Avi", false, false, null, "WAITER1@EXAMPLE.COM", "WAITER1", "AQAAAAIAAYagAAAAEPx5n4t37+tPumSWbP3Ecy7a5K1OlIlMF0iZxXVlJtGsr+urPyMv6Ji+KnTSgwO07g==", null, false, "", false, 2, "waiter1" },
                    { "2", 0, "9884a825-3c7b-4cca-aac0-eea9210aa9c7", "waiter2@example.com", true, "Natan", false, false, null, "WAITER2@EXAMPLE.COM", "WAITER2", "AQAAAAIAAYagAAAAEM/b4LQIy66S/inkDePALmLz377/e0lSKP0WY1gvm1dXqRVJr018ps8rXx6aXyGaxA==", null, false, "", false, 2, "waiter2" },
                    { "3", 0, "821d069c-9a0a-4af3-8454-54fbfaa693a5", "waiter3@example.com", true, "Savarinovvvvv", true, false, null, "WAITER3@EXAMPLE.COM", "WAITER3", "AQAAAAIAAYagAAAAECHH6MTteEnWXl5skWQ80DlzO3ZhI2LrHpRcq4re/SxBHkl4AMWI0qPXDDlo1PP7GQ==", null, false, "", false, 2, "waiter3" },
                    { "4", 0, "477f4c29-9041-4d5a-9c22-489436d483d4", "waiter4@example.com", true, "tal WithlastName", true, false, null, "WAITER4@EXAMPLE.COM", "WAITER4", "AQAAAAIAAYagAAAAEPAUCRxtUE88QSSNnmSqLQJObgqYiW1TmTWJ0WP8Tkath+//joLdJHxMhoU6gpp3bA==", null, false, "", false, 2, "waiter4" }
                });

            migrationBuilder.InsertData(
                table: "Weeks",
                columns: new[] { "ID", "EndDate", "StartDate", "WeekStatus", "WeeklyComment" },
                values: new object[] { 1, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "Description", "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "Type", "WeekId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 2, null, null, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 3, null, null, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 4, null, null, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 5, null, null, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 6, null, null, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 7, null, null, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 1 },
                    { 8, null, null, new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 9, null, null, new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 10, null, null, new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 11, null, null, new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 12, null, null, new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 13, null, null, new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 },
                    { 14, null, null, new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 1 }
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
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_WeekId",
                table: "Shifts",
                column: "WeekId");
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
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Weeks");
        }
    }
}
