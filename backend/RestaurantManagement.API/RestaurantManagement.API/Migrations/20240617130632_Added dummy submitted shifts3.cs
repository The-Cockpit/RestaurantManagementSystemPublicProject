using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class Addeddummysubmittedshifts3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "121526c1-d7aa-4158-8adf-586d9967a446", "AQAAAAIAAYagAAAAEBkX03nseM00puoU+HlkvY737SWfRoIpDUOvk2kskJhoWj4yn9lMpeTAZ0pzzNjsyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13ed3cd4-7093-433b-8fd8-3de7ee770bac", "AQAAAAIAAYagAAAAEBuEsbL91G2uSTP7HhWdYXLxg2kUCU65THf4O2jBq9Sqj1Z5n4y5lwZnFOzyYX52Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20df388b-e6e0-4a2d-a53c-3689e182d232", "AQAAAAIAAYagAAAAEFrEu56bMOhZ7wwYa4iglefCk/bZODtSbrKiiO4dX04o6bcAE2Xmqbu5DJ8FZjYCxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fa88f10-c5ac-4d2e-91ae-747eb34ff173", "AQAAAAIAAYagAAAAEKBflfLrNGqA5q701inV2CgmmjT/cXfxR0RuNwO/WwrgApzJ+Zj87PAOXULO/PwEMQ==" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 30,
                column: "IsTicked",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EmployeeId", "IsTicked", "Status" },
                values: new object[] { "2", true, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EmployeeId", "Status" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "2", new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "2", new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status", "Subject" },
                values: new object[] { null, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndHour", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "2", new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Morning Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "2", new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "2", new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "EndHour", "StartHour", "Subject", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "EndHour", "StartHour", "Subject", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift", 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { "2", new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "Description", "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "Type", "WeekId" },
                values: new object[,]
                {
                    { 771, null, null, new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 772, null, null, new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 773, null, null, new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 774, null, null, new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 775, null, null, new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 776, null, null, new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 777, null, null, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 52 },
                    { 778, null, null, new DateTime(2025, 6, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 779, null, null, new DateTime(2025, 6, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 780, null, null, new DateTime(2025, 6, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 781, null, null, new DateTime(2025, 6, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 782, null, null, new DateTime(2025, 6, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 783, null, null, new DateTime(2025, 6, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 784, null, null, new DateTime(2025, 6, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 52 },
                    { 785, null, null, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 786, null, null, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 787, null, null, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 788, null, null, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 789, null, null, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 790, null, null, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 791, null, null, new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 2, 53 },
                    { 792, null, null, new DateTime(2025, 6, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 793, null, null, new DateTime(2025, 6, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 794, null, null, new DateTime(2025, 6, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 795, null, null, new DateTime(2025, 6, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 796, null, null, new DateTime(2025, 6, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 797, null, null, new DateTime(2025, 6, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 },
                    { 798, null, null, new DateTime(2025, 6, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 2, 53 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 798);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffd58352-6c44-4919-ba64-3a821fed05c0", "AQAAAAIAAYagAAAAEFnl1L1kNGU/X0cvCY1IMiyXzGyDFprXBj+XpQfSpxwatQ/2jGhP0jIunCxdmq5kcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "852edf13-d6d2-47e0-828f-aad8e36e2a1a", "AQAAAAIAAYagAAAAEIVeS3WRADAGNdq4AvJA+ohjWt4qcDooyUExuKJtHlyDICmrODJmc1/gm/DV45cMEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19c2cf6c-6da9-4cc0-9523-543fcdd59cc3", "AQAAAAIAAYagAAAAEOUjPOz8QqGPqWr5Gt/sknuC+jKnM069FoGRreNy9T9imYXkoAC7CD8ezYw7uyBvdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c78ee3c-8d20-47f8-bad0-7e1e9e80d99a", "AQAAAAIAAYagAAAAEKHl3tJykPSOW0vfWP6q0Mhjyg3O2X3Pnuv9XGwRHz1CBD30EEwJxfGz0XO7Q38BqA==" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 30,
                column: "IsTicked",
                value: false);

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "EmployeeId", "IsTicked", "Status" },
                values: new object[] { "1", false, 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "EmployeeId", "Status" },
                values: new object[] { "1", 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "1", new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "EndHour", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { null, new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { null, new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { new DateTime(2024, 6, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { null, new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "EndHour", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Subject" },
                values: new object[] { new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { null, new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Evening Shift" });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour" },
                values: new object[] { "1", new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "EndHour", "IsTicked", "StartHour" },
                values: new object[] { new DateTime(2024, 6, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { null, new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "EmployeeId", "EndHour", "StartHour", "Status" },
                values: new object[] { "1", new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "EndHour", "IsTicked", "StartHour", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "EndHour", "StartHour", "Subject", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 6, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "EndHour", "StartHour", "Subject", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "Subject", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morning Shift", 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "EmployeeId", "EndHour", "IsTicked", "StartHour", "Status", "WeekId" },
                values: new object[] { null, new DateTime(2024, 7, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 7, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 7, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 9, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 11, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2024, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 3, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 4, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 8, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 16, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 18, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 22, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 23, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 5, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 51 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 52 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 13, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "EndHour", "StartHour", "WeekId" },
                values: new object[] { new DateTime(2025, 6, 14, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 53 });
        }
    }
}
