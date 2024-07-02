using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class Generateweeksforayear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df2c3cf2-cbac-410e-91bc-ace048f1ec44", "AQAAAAIAAYagAAAAEBPEh+ceu/Qf9qHCht1CGphuzWEWkjkuf7xuMT+ThHoaSrRIB/AmDZ8uGqlGTRu6vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9db74098-4dd9-4dff-a1e0-7b470e21c1d6", "AQAAAAIAAYagAAAAEMr9Vcwl80SUgZgGn70YhbfLpeJdWk4uDkbsT7LjnjZJOl2Ic7VUNtrDr8L6K1OWBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1f29704-51c2-44ab-9684-bae888cdc4c5", "AQAAAAIAAYagAAAAECjXz22hx1SKw60peyfpMoHgArPRMDLpw8G29BleYRAkxnErFdBGoA83BxqMN5gpgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash" },
                values: new object[] { "e88b9bc8-8ba8-4c9e-bf71-5e1a2b248da2", "Tal Withlastname", "AQAAAAIAAYagAAAAEGfiB+ODeagMPZSQSb6ZOvTQqjd26CrbSvlxRyXSb52EIP7gLIbemIlZJ5rYsY5WuA==" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Weeks",
                columns: new[] { "ID", "EndDate", "StartDate", "WeekStatus", "WeeklyComment" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 3, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 4, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 5, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 6, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 7, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 8, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 9, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 10, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 11, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 12, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 13, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 14, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 15, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 16, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 17, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 18, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 19, new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 20, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 21, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 22, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 23, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 24, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 25, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 26, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 27, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 28, new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 29, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 30, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 31, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 32, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 33, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 34, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 35, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 36, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 37, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 38, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 39, new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 40, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 41, new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 42, new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 43, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 44, new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 45, new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 46, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 47, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 48, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 49, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 50, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 51, new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 52, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null },
                    { 53, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "Description", "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "Type", "WeekId" },
                values: new object[,]
                {
                    { 15, null, null, new DateTime(2024, 6, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 16, null, null, new DateTime(2024, 6, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 17, null, null, new DateTime(2024, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 18, null, null, new DateTime(2024, 6, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 19, null, null, new DateTime(2024, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 20, null, null, new DateTime(2024, 6, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 21, null, null, new DateTime(2024, 6, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 2 },
                    { 22, null, null, new DateTime(2024, 6, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 23, null, null, new DateTime(2024, 6, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 24, null, null, new DateTime(2024, 6, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 25, null, null, new DateTime(2024, 6, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 26, null, null, new DateTime(2024, 6, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 27, null, null, new DateTime(2024, 6, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 28, null, null, new DateTime(2024, 6, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 2 },
                    { 29, null, null, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 30, null, null, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 31, null, null, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 32, null, null, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 33, null, null, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 34, null, null, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 35, null, null, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 3 },
                    { 36, null, null, new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 37, null, null, new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 38, null, null, new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 39, null, null, new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 40, null, null, new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 41, null, null, new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 42, null, null, new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 3 },
                    { 43, null, null, new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 44, null, null, new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 45, null, null, new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 46, null, null, new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 47, null, null, new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 48, null, null, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 49, null, null, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 4 },
                    { 50, null, null, new DateTime(2024, 6, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 51, null, null, new DateTime(2024, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 52, null, null, new DateTime(2024, 7, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 53, null, null, new DateTime(2024, 7, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 54, null, null, new DateTime(2024, 7, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 55, null, null, new DateTime(2024, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 56, null, null, new DateTime(2024, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 4 },
                    { 57, null, null, new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 58, null, null, new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 59, null, null, new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 60, null, null, new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 61, null, null, new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 62, null, null, new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 63, null, null, new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 5 },
                    { 64, null, null, new DateTime(2024, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 65, null, null, new DateTime(2024, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 66, null, null, new DateTime(2024, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 67, null, null, new DateTime(2024, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 68, null, null, new DateTime(2024, 7, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 69, null, null, new DateTime(2024, 7, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 70, null, null, new DateTime(2024, 7, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 5 },
                    { 71, null, null, new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 72, null, null, new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 73, null, null, new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 74, null, null, new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 75, null, null, new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 76, null, null, new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 77, null, null, new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 6 },
                    { 78, null, null, new DateTime(2024, 7, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 79, null, null, new DateTime(2024, 7, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 80, null, null, new DateTime(2024, 7, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 81, null, null, new DateTime(2024, 7, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 82, null, null, new DateTime(2024, 7, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 83, null, null, new DateTime(2024, 7, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 84, null, null, new DateTime(2024, 7, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 6 },
                    { 85, null, null, new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 86, null, null, new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 87, null, null, new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 88, null, null, new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 89, null, null, new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 90, null, null, new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 91, null, null, new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 7 },
                    { 92, null, null, new DateTime(2024, 7, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 93, null, null, new DateTime(2024, 7, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 94, null, null, new DateTime(2024, 7, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 95, null, null, new DateTime(2024, 7, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 96, null, null, new DateTime(2024, 7, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 97, null, null, new DateTime(2024, 7, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 98, null, null, new DateTime(2024, 7, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 7 },
                    { 99, null, null, new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 100, null, null, new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 101, null, null, new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 102, null, null, new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 103, null, null, new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 104, null, null, new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 105, null, null, new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 8 },
                    { 106, null, null, new DateTime(2024, 7, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 107, null, null, new DateTime(2024, 7, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 108, null, null, new DateTime(2024, 7, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 109, null, null, new DateTime(2024, 7, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 110, null, null, new DateTime(2024, 8, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 111, null, null, new DateTime(2024, 8, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 112, null, null, new DateTime(2024, 8, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 8 },
                    { 113, null, null, new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 114, null, null, new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 115, null, null, new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 116, null, null, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 117, null, null, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 118, null, null, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 119, null, null, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 9 },
                    { 120, null, null, new DateTime(2024, 8, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 121, null, null, new DateTime(2024, 8, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 122, null, null, new DateTime(2024, 8, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 123, null, null, new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 124, null, null, new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 125, null, null, new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 126, null, null, new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 9 },
                    { 127, null, null, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 128, null, null, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 129, null, null, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 130, null, null, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 131, null, null, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 132, null, null, new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 133, null, null, new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 10 },
                    { 134, null, null, new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 135, null, null, new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 136, null, null, new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 137, null, null, new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 138, null, null, new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 139, null, null, new DateTime(2024, 8, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 140, null, null, new DateTime(2024, 8, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 10 },
                    { 141, null, null, new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 142, null, null, new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 143, null, null, new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 144, null, null, new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 145, null, null, new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 146, null, null, new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 147, null, null, new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 11 },
                    { 148, null, null, new DateTime(2024, 8, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 149, null, null, new DateTime(2024, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 150, null, null, new DateTime(2024, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 151, null, null, new DateTime(2024, 8, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 152, null, null, new DateTime(2024, 8, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 153, null, null, new DateTime(2024, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 154, null, null, new DateTime(2024, 8, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 11 },
                    { 155, null, null, new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 156, null, null, new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 157, null, null, new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 158, null, null, new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 159, null, null, new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 160, null, null, new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 161, null, null, new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 12 },
                    { 162, null, null, new DateTime(2024, 8, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 163, null, null, new DateTime(2024, 8, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 164, null, null, new DateTime(2024, 8, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 165, null, null, new DateTime(2024, 8, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 166, null, null, new DateTime(2024, 8, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 167, null, null, new DateTime(2024, 8, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 168, null, null, new DateTime(2024, 8, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 12 },
                    { 169, null, null, new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 170, null, null, new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 171, null, null, new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 172, null, null, new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 173, null, null, new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 174, null, null, new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 175, null, null, new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 13 },
                    { 176, null, null, new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 177, null, null, new DateTime(2024, 9, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 178, null, null, new DateTime(2024, 9, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 179, null, null, new DateTime(2024, 9, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 180, null, null, new DateTime(2024, 9, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 181, null, null, new DateTime(2024, 9, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 182, null, null, new DateTime(2024, 9, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 13 },
                    { 183, null, null, new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 184, null, null, new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 185, null, null, new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 186, null, null, new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 187, null, null, new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 188, null, null, new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 189, null, null, new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 14 },
                    { 190, null, null, new DateTime(2024, 9, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 191, null, null, new DateTime(2024, 9, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 192, null, null, new DateTime(2024, 9, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 193, null, null, new DateTime(2024, 9, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 194, null, null, new DateTime(2024, 9, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 195, null, null, new DateTime(2024, 9, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 196, null, null, new DateTime(2024, 9, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 14 },
                    { 197, null, null, new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 198, null, null, new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 199, null, null, new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 200, null, null, new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 201, null, null, new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 202, null, null, new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 203, null, null, new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 15 },
                    { 204, null, null, new DateTime(2024, 9, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 205, null, null, new DateTime(2024, 9, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 206, null, null, new DateTime(2024, 9, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 207, null, null, new DateTime(2024, 9, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 208, null, null, new DateTime(2024, 9, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 209, null, null, new DateTime(2024, 9, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 210, null, null, new DateTime(2024, 9, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 15 },
                    { 211, null, null, new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 212, null, null, new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 213, null, null, new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 214, null, null, new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 215, null, null, new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 216, null, null, new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 217, null, null, new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 16 },
                    { 218, null, null, new DateTime(2024, 9, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 219, null, null, new DateTime(2024, 9, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 220, null, null, new DateTime(2024, 9, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 221, null, null, new DateTime(2024, 9, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 222, null, null, new DateTime(2024, 9, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 223, null, null, new DateTime(2024, 9, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 224, null, null, new DateTime(2024, 9, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 16 },
                    { 225, null, null, new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 226, null, null, new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 227, null, null, new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 228, null, null, new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 229, null, null, new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 230, null, null, new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 231, null, null, new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 17 },
                    { 232, null, null, new DateTime(2024, 9, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 233, null, null, new DateTime(2024, 9, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 234, null, null, new DateTime(2024, 10, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 235, null, null, new DateTime(2024, 10, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 236, null, null, new DateTime(2024, 10, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 237, null, null, new DateTime(2024, 10, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 238, null, null, new DateTime(2024, 10, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 17 },
                    { 239, null, null, new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 240, null, null, new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 241, null, null, new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 242, null, null, new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 243, null, null, new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 244, null, null, new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 245, null, null, new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 18 },
                    { 246, null, null, new DateTime(2024, 10, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 247, null, null, new DateTime(2024, 10, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 248, null, null, new DateTime(2024, 10, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 249, null, null, new DateTime(2024, 10, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 250, null, null, new DateTime(2024, 10, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 251, null, null, new DateTime(2024, 10, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 252, null, null, new DateTime(2024, 10, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 18 },
                    { 253, null, null, new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 254, null, null, new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 255, null, null, new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 256, null, null, new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 257, null, null, new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 258, null, null, new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 259, null, null, new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 19 },
                    { 260, null, null, new DateTime(2024, 10, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 261, null, null, new DateTime(2024, 10, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 262, null, null, new DateTime(2024, 10, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 263, null, null, new DateTime(2024, 10, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 264, null, null, new DateTime(2024, 10, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 265, null, null, new DateTime(2024, 10, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 266, null, null, new DateTime(2024, 10, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 19 },
                    { 267, null, null, new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 268, null, null, new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 269, null, null, new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 270, null, null, new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 271, null, null, new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 272, null, null, new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 273, null, null, new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 20 },
                    { 274, null, null, new DateTime(2024, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 275, null, null, new DateTime(2024, 10, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 276, null, null, new DateTime(2024, 10, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 277, null, null, new DateTime(2024, 10, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 278, null, null, new DateTime(2024, 10, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 279, null, null, new DateTime(2024, 10, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 280, null, null, new DateTime(2024, 10, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 20 },
                    { 281, null, null, new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 282, null, null, new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 283, null, null, new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 284, null, null, new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 285, null, null, new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 286, null, null, new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 287, null, null, new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 21 },
                    { 288, null, null, new DateTime(2024, 10, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 289, null, null, new DateTime(2024, 10, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 290, null, null, new DateTime(2024, 10, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 291, null, null, new DateTime(2024, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 292, null, null, new DateTime(2024, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 293, null, null, new DateTime(2024, 11, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 294, null, null, new DateTime(2024, 11, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 21 },
                    { 295, null, null, new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 296, null, null, new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 297, null, null, new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 298, null, null, new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 299, null, null, new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 300, null, null, new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 301, null, null, new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 22 },
                    { 302, null, null, new DateTime(2024, 11, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 303, null, null, new DateTime(2024, 11, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 304, null, null, new DateTime(2024, 11, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 305, null, null, new DateTime(2024, 11, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 306, null, null, new DateTime(2024, 11, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 307, null, null, new DateTime(2024, 11, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 308, null, null, new DateTime(2024, 11, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 22 },
                    { 309, null, null, new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 310, null, null, new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 311, null, null, new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 312, null, null, new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 313, null, null, new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 314, null, null, new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 315, null, null, new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 23 },
                    { 316, null, null, new DateTime(2024, 11, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 317, null, null, new DateTime(2024, 11, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 318, null, null, new DateTime(2024, 11, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 319, null, null, new DateTime(2024, 11, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 320, null, null, new DateTime(2024, 11, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 321, null, null, new DateTime(2024, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 322, null, null, new DateTime(2024, 11, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 23 },
                    { 323, null, null, new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 324, null, null, new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 325, null, null, new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 326, null, null, new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 327, null, null, new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 328, null, null, new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 329, null, null, new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 24 },
                    { 330, null, null, new DateTime(2024, 11, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 331, null, null, new DateTime(2024, 11, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 332, null, null, new DateTime(2024, 11, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 333, null, null, new DateTime(2024, 11, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 334, null, null, new DateTime(2024, 11, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 335, null, null, new DateTime(2024, 11, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 336, null, null, new DateTime(2024, 11, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 24 },
                    { 337, null, null, new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 338, null, null, new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 339, null, null, new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 340, null, null, new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 341, null, null, new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 342, null, null, new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 343, null, null, new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 25 },
                    { 344, null, null, new DateTime(2024, 11, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 345, null, null, new DateTime(2024, 11, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 346, null, null, new DateTime(2024, 11, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 347, null, null, new DateTime(2024, 11, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 348, null, null, new DateTime(2024, 11, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 349, null, null, new DateTime(2024, 11, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 350, null, null, new DateTime(2024, 11, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 25 },
                    { 351, null, null, new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 352, null, null, new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 353, null, null, new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 354, null, null, new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 355, null, null, new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 356, null, null, new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 357, null, null, new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 26 },
                    { 358, null, null, new DateTime(2024, 12, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 359, null, null, new DateTime(2024, 12, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 360, null, null, new DateTime(2024, 12, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 361, null, null, new DateTime(2024, 12, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 362, null, null, new DateTime(2024, 12, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 363, null, null, new DateTime(2024, 12, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 364, null, null, new DateTime(2024, 12, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 26 },
                    { 365, null, null, new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 366, null, null, new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 367, null, null, new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 368, null, null, new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 369, null, null, new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 370, null, null, new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 371, null, null, new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 27 },
                    { 372, null, null, new DateTime(2024, 12, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 373, null, null, new DateTime(2024, 12, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 374, null, null, new DateTime(2024, 12, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 375, null, null, new DateTime(2024, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 376, null, null, new DateTime(2024, 12, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 377, null, null, new DateTime(2024, 12, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 378, null, null, new DateTime(2024, 12, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 27 },
                    { 379, null, null, new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 380, null, null, new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 381, null, null, new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 382, null, null, new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 383, null, null, new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 384, null, null, new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 385, null, null, new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 28 },
                    { 386, null, null, new DateTime(2024, 12, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 387, null, null, new DateTime(2024, 12, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 388, null, null, new DateTime(2024, 12, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 389, null, null, new DateTime(2024, 12, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 390, null, null, new DateTime(2024, 12, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 391, null, null, new DateTime(2024, 12, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 392, null, null, new DateTime(2024, 12, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 28 },
                    { 393, null, null, new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 394, null, null, new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 395, null, null, new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 396, null, null, new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 397, null, null, new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 398, null, null, new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 399, null, null, new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 29 },
                    { 400, null, null, new DateTime(2024, 12, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 401, null, null, new DateTime(2024, 12, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 402, null, null, new DateTime(2024, 12, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 403, null, null, new DateTime(2024, 12, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 404, null, null, new DateTime(2024, 12, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 405, null, null, new DateTime(2024, 12, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 406, null, null, new DateTime(2024, 12, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 29 },
                    { 407, null, null, new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 408, null, null, new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 409, null, null, new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 410, null, null, new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 411, null, null, new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 412, null, null, new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 413, null, null, new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 30 },
                    { 414, null, null, new DateTime(2024, 12, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 415, null, null, new DateTime(2024, 12, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 416, null, null, new DateTime(2024, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 417, null, null, new DateTime(2025, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 418, null, null, new DateTime(2025, 1, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 419, null, null, new DateTime(2025, 1, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 420, null, null, new DateTime(2025, 1, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 30 },
                    { 421, null, null, new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 422, null, null, new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 423, null, null, new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 424, null, null, new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 425, null, null, new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 426, null, null, new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 427, null, null, new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 31 },
                    { 428, null, null, new DateTime(2025, 1, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 429, null, null, new DateTime(2025, 1, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 430, null, null, new DateTime(2025, 1, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 431, null, null, new DateTime(2025, 1, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 432, null, null, new DateTime(2025, 1, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 433, null, null, new DateTime(2025, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 434, null, null, new DateTime(2025, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 31 },
                    { 435, null, null, new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 436, null, null, new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 437, null, null, new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 438, null, null, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 439, null, null, new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 440, null, null, new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 441, null, null, new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 32 },
                    { 442, null, null, new DateTime(2025, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 443, null, null, new DateTime(2025, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 444, null, null, new DateTime(2025, 1, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 445, null, null, new DateTime(2025, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 446, null, null, new DateTime(2025, 1, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 447, null, null, new DateTime(2025, 1, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 448, null, null, new DateTime(2025, 1, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 32 },
                    { 449, null, null, new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 450, null, null, new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 451, null, null, new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 452, null, null, new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 453, null, null, new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 454, null, null, new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 455, null, null, new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 33 },
                    { 456, null, null, new DateTime(2025, 1, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 457, null, null, new DateTime(2025, 1, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 458, null, null, new DateTime(2025, 1, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 459, null, null, new DateTime(2025, 1, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 460, null, null, new DateTime(2025, 1, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 461, null, null, new DateTime(2025, 1, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 462, null, null, new DateTime(2025, 1, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 33 },
                    { 463, null, null, new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 464, null, null, new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 465, null, null, new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 466, null, null, new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 467, null, null, new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 468, null, null, new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 469, null, null, new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 34 },
                    { 470, null, null, new DateTime(2025, 1, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 471, null, null, new DateTime(2025, 1, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 472, null, null, new DateTime(2025, 1, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 473, null, null, new DateTime(2025, 1, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 474, null, null, new DateTime(2025, 1, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 475, null, null, new DateTime(2025, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 476, null, null, new DateTime(2025, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 34 },
                    { 477, null, null, new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 478, null, null, new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 479, null, null, new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 480, null, null, new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 481, null, null, new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 482, null, null, new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 483, null, null, new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 35 },
                    { 484, null, null, new DateTime(2025, 2, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 485, null, null, new DateTime(2025, 2, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 486, null, null, new DateTime(2025, 2, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 487, null, null, new DateTime(2025, 2, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 488, null, null, new DateTime(2025, 2, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 489, null, null, new DateTime(2025, 2, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 490, null, null, new DateTime(2025, 2, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 35 },
                    { 491, null, null, new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 492, null, null, new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 493, null, null, new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 494, null, null, new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 495, null, null, new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 496, null, null, new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 497, null, null, new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 36 },
                    { 498, null, null, new DateTime(2025, 2, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 499, null, null, new DateTime(2025, 2, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 500, null, null, new DateTime(2025, 2, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 501, null, null, new DateTime(2025, 2, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 502, null, null, new DateTime(2025, 2, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 503, null, null, new DateTime(2025, 2, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 504, null, null, new DateTime(2025, 2, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 36 },
                    { 505, null, null, new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 506, null, null, new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 507, null, null, new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 508, null, null, new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 509, null, null, new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 510, null, null, new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 511, null, null, new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 37 },
                    { 512, null, null, new DateTime(2025, 2, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 513, null, null, new DateTime(2025, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 514, null, null, new DateTime(2025, 2, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 515, null, null, new DateTime(2025, 2, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 516, null, null, new DateTime(2025, 2, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 517, null, null, new DateTime(2025, 2, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 518, null, null, new DateTime(2025, 2, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 37 },
                    { 519, null, null, new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 520, null, null, new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 521, null, null, new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 522, null, null, new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 523, null, null, new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 524, null, null, new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 525, null, null, new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 38 },
                    { 526, null, null, new DateTime(2025, 2, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 527, null, null, new DateTime(2025, 2, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 528, null, null, new DateTime(2025, 2, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 529, null, null, new DateTime(2025, 2, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 530, null, null, new DateTime(2025, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 531, null, null, new DateTime(2025, 2, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 532, null, null, new DateTime(2025, 3, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 38 },
                    { 533, null, null, new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 534, null, null, new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 535, null, null, new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 536, null, null, new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 537, null, null, new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 538, null, null, new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 539, null, null, new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 39 },
                    { 540, null, null, new DateTime(2025, 3, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 541, null, null, new DateTime(2025, 3, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 542, null, null, new DateTime(2025, 3, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 543, null, null, new DateTime(2025, 3, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 544, null, null, new DateTime(2025, 3, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 545, null, null, new DateTime(2025, 3, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 546, null, null, new DateTime(2025, 3, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 39 },
                    { 547, null, null, new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 548, null, null, new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 549, null, null, new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 550, null, null, new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 551, null, null, new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 552, null, null, new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 553, null, null, new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 40 },
                    { 554, null, null, new DateTime(2025, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 555, null, null, new DateTime(2025, 3, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 556, null, null, new DateTime(2025, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 557, null, null, new DateTime(2025, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 558, null, null, new DateTime(2025, 3, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 559, null, null, new DateTime(2025, 3, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 560, null, null, new DateTime(2025, 3, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 40 },
                    { 561, null, null, new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 562, null, null, new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 563, null, null, new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 564, null, null, new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 565, null, null, new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 566, null, null, new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 567, null, null, new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 41 },
                    { 568, null, null, new DateTime(2025, 3, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 569, null, null, new DateTime(2025, 3, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 570, null, null, new DateTime(2025, 3, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 571, null, null, new DateTime(2025, 3, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 572, null, null, new DateTime(2025, 3, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 573, null, null, new DateTime(2025, 3, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 574, null, null, new DateTime(2025, 3, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 41 },
                    { 575, null, null, new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 576, null, null, new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 577, null, null, new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 578, null, null, new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 579, null, null, new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 580, null, null, new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 581, null, null, new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 42 },
                    { 582, null, null, new DateTime(2025, 3, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 583, null, null, new DateTime(2025, 3, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 584, null, null, new DateTime(2025, 3, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 585, null, null, new DateTime(2025, 3, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 586, null, null, new DateTime(2025, 3, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 587, null, null, new DateTime(2025, 3, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 588, null, null, new DateTime(2025, 3, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 42 },
                    { 589, null, null, new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 590, null, null, new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 591, null, null, new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 592, null, null, new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 593, null, null, new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 594, null, null, new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 595, null, null, new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 43 },
                    { 596, null, null, new DateTime(2025, 3, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 597, null, null, new DateTime(2025, 3, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 598, null, null, new DateTime(2025, 4, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 599, null, null, new DateTime(2025, 4, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 600, null, null, new DateTime(2025, 4, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 601, null, null, new DateTime(2025, 4, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 602, null, null, new DateTime(2025, 4, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 43 },
                    { 603, null, null, new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 604, null, null, new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 605, null, null, new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 606, null, null, new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 607, null, null, new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 608, null, null, new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 609, null, null, new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 44 },
                    { 610, null, null, new DateTime(2025, 4, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 611, null, null, new DateTime(2025, 4, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 612, null, null, new DateTime(2025, 4, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 613, null, null, new DateTime(2025, 4, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 614, null, null, new DateTime(2025, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 615, null, null, new DateTime(2025, 4, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 616, null, null, new DateTime(2025, 4, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 44 },
                    { 617, null, null, new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 618, null, null, new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 619, null, null, new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 620, null, null, new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 621, null, null, new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 622, null, null, new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 623, null, null, new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 45 },
                    { 624, null, null, new DateTime(2025, 4, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 625, null, null, new DateTime(2025, 4, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 626, null, null, new DateTime(2025, 4, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 627, null, null, new DateTime(2025, 4, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 628, null, null, new DateTime(2025, 4, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 629, null, null, new DateTime(2025, 4, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 630, null, null, new DateTime(2025, 4, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 45 },
                    { 631, null, null, new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 632, null, null, new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 633, null, null, new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 634, null, null, new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 635, null, null, new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 636, null, null, new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 637, null, null, new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 46 },
                    { 638, null, null, new DateTime(2025, 4, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 639, null, null, new DateTime(2025, 4, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 640, null, null, new DateTime(2025, 4, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 641, null, null, new DateTime(2025, 4, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 642, null, null, new DateTime(2025, 4, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 643, null, null, new DateTime(2025, 4, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 644, null, null, new DateTime(2025, 4, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 46 },
                    { 645, null, null, new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 646, null, null, new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 647, null, null, new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 648, null, null, new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 649, null, null, new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 650, null, null, new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 651, null, null, new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 47 },
                    { 652, null, null, new DateTime(2025, 4, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 653, null, null, new DateTime(2025, 4, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 654, null, null, new DateTime(2025, 4, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 655, null, null, new DateTime(2025, 4, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 656, null, null, new DateTime(2025, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 657, null, null, new DateTime(2025, 5, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 658, null, null, new DateTime(2025, 5, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 47 },
                    { 659, null, null, new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 660, null, null, new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 661, null, null, new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 662, null, null, new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 663, null, null, new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 664, null, null, new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 665, null, null, new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 48 },
                    { 666, null, null, new DateTime(2025, 5, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 667, null, null, new DateTime(2025, 5, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 668, null, null, new DateTime(2025, 5, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 669, null, null, new DateTime(2025, 5, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 670, null, null, new DateTime(2025, 5, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 671, null, null, new DateTime(2025, 5, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 672, null, null, new DateTime(2025, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 48 },
                    { 673, null, null, new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 674, null, null, new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 675, null, null, new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 676, null, null, new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 677, null, null, new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 678, null, null, new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 679, null, null, new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 49 },
                    { 680, null, null, new DateTime(2025, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 681, null, null, new DateTime(2025, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 682, null, null, new DateTime(2025, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 683, null, null, new DateTime(2025, 5, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 684, null, null, new DateTime(2025, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 685, null, null, new DateTime(2025, 5, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 686, null, null, new DateTime(2025, 5, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 49 },
                    { 687, null, null, new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 688, null, null, new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 689, null, null, new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 690, null, null, new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 691, null, null, new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 692, null, null, new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 693, null, null, new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 50 },
                    { 694, null, null, new DateTime(2025, 5, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 695, null, null, new DateTime(2025, 5, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 696, null, null, new DateTime(2025, 5, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 697, null, null, new DateTime(2025, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 698, null, null, new DateTime(2025, 5, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 699, null, null, new DateTime(2025, 5, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 700, null, null, new DateTime(2025, 5, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 50 },
                    { 701, null, null, new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 702, null, null, new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 703, null, null, new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 704, null, null, new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 705, null, null, new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 706, null, null, new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 707, null, null, new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 51 },
                    { 708, null, null, new DateTime(2025, 5, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 709, null, null, new DateTime(2025, 5, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 710, null, null, new DateTime(2025, 5, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 711, null, null, new DateTime(2025, 5, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 712, null, null, new DateTime(2025, 5, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 713, null, null, new DateTime(2025, 5, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 714, null, null, new DateTime(2025, 5, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 51 },
                    { 715, null, null, new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 716, null, null, new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 717, null, null, new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 718, null, null, new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 719, null, null, new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 720, null, null, new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 721, null, null, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 52 },
                    { 722, null, null, new DateTime(2025, 6, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 723, null, null, new DateTime(2025, 6, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 724, null, null, new DateTime(2025, 6, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 725, null, null, new DateTime(2025, 6, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 726, null, null, new DateTime(2025, 6, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 727, null, null, new DateTime(2025, 6, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 728, null, null, new DateTime(2025, 6, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 52 },
                    { 729, null, null, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 730, null, null, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 731, null, null, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 732, null, null, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 733, null, null, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 734, null, null, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 735, null, null, new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת בוקר", 2, 53 },
                    { 736, null, null, new DateTime(2025, 6, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 737, null, null, new DateTime(2025, 6, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 738, null, null, new DateTime(2025, 6, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 739, null, null, new DateTime(2025, 6, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 740, null, null, new DateTime(2025, 6, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 741, null, null, new DateTime(2025, 6, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 },
                    { 742, null, null, new DateTime(2025, 6, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "משמרת ערב", 2, 53 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "216b9c39-c4a0-4c0d-ac5c-4c487a8452f0", "AQAAAAIAAYagAAAAEPx5n4t37+tPumSWbP3Ecy7a5K1OlIlMF0iZxXVlJtGsr+urPyMv6Ji+KnTSgwO07g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9884a825-3c7b-4cca-aac0-eea9210aa9c7", "AQAAAAIAAYagAAAAEM/b4LQIy66S/inkDePALmLz377/e0lSKP0WY1gvm1dXqRVJr018ps8rXx6aXyGaxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "821d069c-9a0a-4af3-8454-54fbfaa693a5", "AQAAAAIAAYagAAAAECHH6MTteEnWXl5skWQ80DlzO3ZhI2LrHpRcq4re/SxBHkl4AMWI0qPXDDlo1PP7GQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash" },
                values: new object[] { "477f4c29-9041-4d5a-9c22-489436d483d4", "tal WithlastName", "AQAAAAIAAYagAAAAEPAUCRxtUE88QSSNnmSqLQJObgqYiW1TmTWJ0WP8Tkath+//joLdJHxMhoU6gpp3bA==" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
