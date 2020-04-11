using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreUIAppn.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingSubject = table.Column<string>(type: "varchar(100)", nullable: false),
                    Attendees = table.Column<string>(type: "varchar(200)", nullable: false),
                    MeetingAgenda = table.Column<string>(type: "varchar(4000)", nullable: false),
                    MeetingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
