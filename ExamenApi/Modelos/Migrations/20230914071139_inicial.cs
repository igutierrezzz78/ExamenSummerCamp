using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "id", "FechaNacimiento", "Nombre", "Telefono", "UserName", "apellido", "password" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandra", "638354533", "Sandra", "Jimenez", "1234567" },
                    { 2, new DateTime(1990, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "pepe", "63234233", "Pepe", "Jimenez", "1234567" },
                    { 3, new DateTime(1945, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "638234533", "Juan", "Jimenez", "1234567" },
                    { 4, new DateTime(2006, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andres", "63567533", "Andres", "Jimenez", "1234567" },
                    { 5, new DateTime(2008, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando", "632344533", "Fernando", "Jimenez", "1234567" },
                    { 6, new DateTime(2001, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jose", "634324533", "Jose", "Jimenez", "1234567" },
                    { 7, new DateTime(1983, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dani", "634324533", "Dani", "Jimenez", "1234567" },
                    { 8, new DateTime(1995, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "631234567", "Laura", "Gomez", "1234567" },
                    { 9, new DateTime(1987, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "636789012", "Carlos", "Perez", "1234567" },
                    { 10, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "639567890", "Isabel", "Lopez", "1234567" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
