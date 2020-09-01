using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Customers_CustomerID",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "CustomerMaster");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerMaster",
                table: "CustomerMaster",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_CustomerMaster_CustomerID",
                table: "CustomerAddress",
                column: "CustomerID",
                principalTable: "CustomerMaster",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_CustomerMaster_CustomerID",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerMaster",
                table: "CustomerMaster");

            migrationBuilder.RenameTable(
                name: "CustomerMaster",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Customers_CustomerID",
                table: "CustomerAddress",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
