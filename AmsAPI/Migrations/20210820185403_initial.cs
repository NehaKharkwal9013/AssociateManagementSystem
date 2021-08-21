using Microsoft.EntityFrameworkCore.Migrations;

namespace AmsAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecializationMasters",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationName = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializationMasters", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "AssociatesMasters",
                columns: table => new
                {
                    AssociateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociateName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatesMasters", x => x.AssociateId);
                    table.ForeignKey(
                        name: "FK_AssociatesMasters_SpecializationMasters_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "SpecializationMasters",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociatesMasters_SpecializationId",
                table: "AssociatesMasters",
                column: "SpecializationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociatesMasters");

            migrationBuilder.DropTable(
                name: "SpecializationMasters");
        }
    }
}
