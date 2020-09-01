using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFFluentApi.Migrations
{
    public partial class CityInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityInformation",
                table: "CityInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityInformationId",
                table: "CityInformation");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CityInformation",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityInformation",
                table: "CityInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities",
                column: "CityInformationId",
                principalTable: "CityInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityInformation",
                table: "CityInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CityInformation");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityInformationId",
                table: "CityInformation",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityInformation",
                table: "CityInformation",
                column: "CityInformationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities",
                column: "CityInformationId",
                principalTable: "CityInformation",
                principalColumn: "CityInformationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
