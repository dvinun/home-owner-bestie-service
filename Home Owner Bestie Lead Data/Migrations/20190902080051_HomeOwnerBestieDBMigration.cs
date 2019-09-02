using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeOwnerBestie.LeadData.SQL.Migrations
{
    public partial class HomeOwnerBestieDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    UserID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 256, nullable: true),
                    LastName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    Phone = table.Column<string>(maxLength: 24, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "RentValuationReports",
                columns: table => new
                {
                    RentValuationRecordID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AverageMonthlyRent = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ValueChangedIn30Days = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ValuationRentHigh = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ValuationRentLow = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IsRentEstimateAvailable = table.Column<bool>(nullable: true),
                    UserID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    HomeOwnerSpecifiedRent = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentValuationData", x => x.RentValuationRecordID);
                    table.ForeignKey(
                        name: "FK_RentValuationData_AppUsers",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    AddressID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 512, nullable: true),
                    City = table.Column<string>(maxLength: 128, nullable: true),
                    Zip = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    County = table.Column<string>(maxLength: 128, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_UserAddresses_AppUsers",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserIPAddresses",
                columns: table => new
                {
                    IPAddressRecordID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IPAddress = table.Column<string>(maxLength: 24, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIPAddresses", x => x.IPAddressRecordID);
                    table.ForeignKey(
                        name: "FK_UserIPAddresses_AppUsers",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentValuationReports_UserID",
                table: "RentValuationReports",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_UserID",
                table: "UserAddresses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserIPAddresses_UserID",
                table: "UserIPAddresses",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentValuationReports");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserIPAddresses");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
