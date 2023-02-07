using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlumniAssociationF.Data.Migrations
{
    public partial class addhash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordH",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordH",
                table: "AspNetUsers");
        }
    }
}
