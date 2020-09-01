using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class DbTypeTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbTypeTests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestString = table.Column<string>(nullable: true),
                    TestDecimal = table.Column<decimal>(nullable: false),
                    TestDecimalNull = table.Column<decimal>(nullable: true),
                    TestDouble = table.Column<double>(nullable: false),
                    TestDoubleNull = table.Column<double>(nullable: true),
                    Testint = table.Column<int>(nullable: false),
                    TestIntNull = table.Column<int>(nullable: true),
                    Testbool = table.Column<bool>(nullable: false),
                    TestboolNull = table.Column<bool>(nullable: true),
                    TestDateTime = table.Column<DateTime>(nullable: false),
                    TestDateTimeNull = table.Column<DateTime>(nullable: true),
                    TestByte = table.Column<byte>(nullable: false),
                    TestByteNull = table.Column<byte>(nullable: true),
                    TestByteA = table.Column<byte[]>(nullable: true),
                    TestUnit = table.Column<long>(nullable: false),
                    TestUnitNull = table.Column<long>(nullable: true),
                    TestShort = table.Column<short>(nullable: false),
                    TestUShort = table.Column<int>(nullable: false),
                    testChar = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbTypeTests", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbTypeTests");
        }
    }
}
