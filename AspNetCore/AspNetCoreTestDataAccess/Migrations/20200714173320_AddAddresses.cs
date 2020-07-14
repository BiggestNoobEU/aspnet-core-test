using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTestDataAccess.Migrations
{
    public partial class AddAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "People",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNr = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_AddressId",
                table: "People",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Address_AddressId",
                table: "People",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Address_AddressId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_People_AddressId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
