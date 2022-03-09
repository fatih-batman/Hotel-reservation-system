using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Migrations
{
    public partial class resX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_out = table.Column<DateTime>(type: "datetime2", nullable: false),
                    made_by = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    guest_first_name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    guest_last_name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    room_number = table.Column<int>(type: "int", nullable: false),
                    check_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    check_out = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");
        }
    }
}
