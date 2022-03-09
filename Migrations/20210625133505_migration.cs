using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "guest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    last_name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    member_since = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "room_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    max_capasity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_out = table.Column<DateTime>(type: "datetime2", nullable: false),
                    made_by = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    guest_idid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.id);
                    table.ForeignKey(
                        name: "FK_reservation_guest_guest_idid",
                        column: x => x.guest_idid,
                        principalTable: "guest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    status = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    smoke = table.Column<bool>(type: "bit", nullable: false),
                    room_type_idid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_room_type_room_type_idid",
                        column: x => x.room_type_idid,
                        principalTable: "room_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reserved_room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number_of_room = table.Column<int>(type: "int", nullable: false),
                    room_type_idid = table.Column<int>(type: "int", nullable: true),
                    reservation_idid = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserved_room", x => x.id);
                    table.ForeignKey(
                        name: "FK_reserved_room_reservation_reservation_idid",
                        column: x => x.reservation_idid,
                        principalTable: "reservation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_reserved_room_room_type_room_type_idid",
                        column: x => x.room_type_idid,
                        principalTable: "room_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "occupied_room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    check_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    check_out = table.Column<DateTime>(type: "datetime2", nullable: false),
                    room_idid = table.Column<int>(type: "int", nullable: true),
                    reservation_idid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_occupied_room", x => x.id);
                    table.ForeignKey(
                        name: "FK_occupied_room_reservation_reservation_idid",
                        column: x => x.reservation_idid,
                        principalTable: "reservation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_occupied_room_room_room_idid",
                        column: x => x.room_idid,
                        principalTable: "room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hosted_at",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guest_idid = table.Column<int>(type: "int", nullable: true),
                    occupied_room_idid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hosted_at", x => x.id);
                    table.ForeignKey(
                        name: "FK_hosted_at_guest_guest_idid",
                        column: x => x.guest_idid,
                        principalTable: "guest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_hosted_at_occupied_room_occupied_room_idid",
                        column: x => x.occupied_room_idid,
                        principalTable: "occupied_room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hosted_at_guest_idid",
                table: "hosted_at",
                column: "guest_idid");

            migrationBuilder.CreateIndex(
                name: "IX_hosted_at_occupied_room_idid",
                table: "hosted_at",
                column: "occupied_room_idid");

            migrationBuilder.CreateIndex(
                name: "IX_occupied_room_reservation_idid",
                table: "occupied_room",
                column: "reservation_idid");

            migrationBuilder.CreateIndex(
                name: "IX_occupied_room_room_idid",
                table: "occupied_room",
                column: "room_idid");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_guest_idid",
                table: "reservation",
                column: "guest_idid");

            migrationBuilder.CreateIndex(
                name: "IX_reserved_room_reservation_idid",
                table: "reserved_room",
                column: "reservation_idid");

            migrationBuilder.CreateIndex(
                name: "IX_reserved_room_room_type_idid",
                table: "reserved_room",
                column: "room_type_idid");

            migrationBuilder.CreateIndex(
                name: "IX_room_room_type_idid",
                table: "room",
                column: "room_type_idid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hosted_at");

            migrationBuilder.DropTable(
                name: "reserved_room");

            migrationBuilder.DropTable(
                name: "occupied_room");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "room");

            migrationBuilder.DropTable(
                name: "guest");

            migrationBuilder.DropTable(
                name: "room_type");
        }
    }
}
