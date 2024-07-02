using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class addedconfigmodelandShiftSelectionTemplatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalizeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShiftSelectionTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartHour = table.Column<int>(type: "int", nullable: false),
                    StartMin = table.Column<int>(type: "int", nullable: false),
                    EndHour = table.Column<int>(type: "int", nullable: false),
                    EndMin = table.Column<int>(type: "int", nullable: false),
                    ConfigID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftSelectionTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShiftSelectionTemplates_Configs_ConfigID",
                        column: x => x.ConfigID,
                        principalTable: "Configs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fdb6253-156f-4dfd-881d-d37a38523ecc", "AQAAAAIAAYagAAAAEGE0akdv/BkgV619G0ICNgG3yR+xPZ+Fb/YisaIeKKwPNO7dz2zQjScKeootVPNhmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae002146-936b-4a84-88a3-d13e8c87efcd", "AQAAAAIAAYagAAAAEEZjxLeCGm/JQjpSuTx9ucy+RPW0NNESYdVjIlJRf5tG3fs1nfXedu4KuhKGkFk18g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8896b76b-a836-4271-a659-417dd6cbb1f5", "AQAAAAIAAYagAAAAENvobIRQaHSBXQiN9PFH5oWkZJeokHIZ40mnjTOc8sq2G1OmEMztZxvYEM+cClRnWA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e55b91d-72af-498b-86f0-6afa6a8aa3e7", "AQAAAAIAAYagAAAAEEDRsGpvQcnLc4hzSlz1Ws6B6gK7QyHXuMYSbgO1C23cu87AvoC/2Pb6gWQxEcJt7A==" });

            migrationBuilder.CreateIndex(
                name: "IX_ShiftSelectionTemplates_ConfigID",
                table: "ShiftSelectionTemplates",
                column: "ConfigID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShiftSelectionTemplates");

            migrationBuilder.DropTable(
                name: "Configs");

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
        }
    }
}
