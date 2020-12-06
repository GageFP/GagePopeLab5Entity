using Microsoft.EntityFrameworkCore.Migrations;

namespace GagePopeLab5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    weaponName = table.Column<string>(nullable: false),
                    weaponDamage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.weaponName);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    characterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterName = table.Column<string>(nullable: true),
                    characterHealth = table.Column<int>(nullable: false),
                    weaponName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.characterID);
                    table.ForeignKey(
                        name: "FK_Characters_Weapons_weaponName",
                        column: x => x.weaponName,
                        principalTable: "Weapons",
                        principalColumn: "weaponName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_weaponName",
                table: "Characters",
                column: "weaponName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
