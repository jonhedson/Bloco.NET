using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFFluentApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityInformation",
                columns: table => new
                {
                    CityInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Population = table.Column<int>(nullable: false),
                    OtherName = table.Column<int>(nullable: false),
                    MayorName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityInformation", x => x.CityInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: false, defaultValue: "USA"),
                    AddedOne = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FKCountry = table.Column<int>(nullable: false),
                    CityInformationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_CityInformation_CityInformationId",
                        column: x => x.CityInformationId,
                        principalTable: "CityInformation",
                        principalColumn: "CityInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_FKCountry",
                        column: x => x.FKCountry,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityInformationId",
                table: "Cities",
                column: "CityInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_FKCountry",
                table: "Cities",
                column: "FKCountry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CityInformation");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
