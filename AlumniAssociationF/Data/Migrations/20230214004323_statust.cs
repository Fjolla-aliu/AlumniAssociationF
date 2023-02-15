using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace AlumniAssociationF.Data.Migrations
{
    public partial class statust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       //     migrationBuilder.CreateTable(
       //         name: "About",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_About", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetRoles",
       //         columns: table => new
       //         {
       //             Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetRoles", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetUsers",
       //         columns: table => new
       //         {
       //             Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             PasswordH = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
       //             PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
       //             RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
       //             EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
       //             PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
       //             TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
       //             LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
       //             LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
       //             AccessFailedCount = table.Column<int>(type: "int", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetUsers", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "Center",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_Center", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "FAQs",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_FAQs", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "News",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Date = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_News", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "OurProgram",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_OurProgram", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "Partners",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             City = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             State = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_Partners", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "Students",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             City = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             State = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             University = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             AvGrade = table.Column<double>(type: "float", nullable: false),
       //             Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             JobStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_Students", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "Team",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_Team", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "ViewUser",
       //         columns: table => new
       //         {
       //             Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             PasswordH = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
       //             PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
       //             RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             TokenCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             TokenExpires = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
       //             Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_ViewUser", x => x.Id);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetRoleClaims",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
       //             table.ForeignKey(
       //                 name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
       //                 column: x => x.RoleId,
       //                 principalTable: "AspNetRoles",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetUserClaims",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
       //             table.ForeignKey(
       //                 name: "FK_AspNetUserClaims_AspNetUsers_UserId",
       //                 column: x => x.UserId,
       //                 principalTable: "AspNetUsers",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetUserLogins",
       //         columns: table => new
       //         {
       //             LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
       //             ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
       //             ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
       //             UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
       //             table.ForeignKey(
       //                 name: "FK_AspNetUserLogins_AspNetUsers_UserId",
       //                 column: x => x.UserId,
       //                 principalTable: "AspNetUsers",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetUserRoles",
       //         columns: table => new
       //         {
       //             UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
       //             table.ForeignKey(
       //                 name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
       //                 column: x => x.RoleId,
       //                 principalTable: "AspNetRoles",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //             table.ForeignKey(
       //                 name: "FK_AspNetUserRoles_AspNetUsers_UserId",
       //                 column: x => x.UserId,
       //                 principalTable: "AspNetUsers",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "AspNetUserTokens",
       //         columns: table => new
       //         {
       //             UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
       //             LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
       //             Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
       //             Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
       //             table.ForeignKey(
       //                 name: "FK_AspNetUserTokens_AspNetUsers_UserId",
       //                 column: x => x.UserId,
       //                 principalTable: "AspNetUsers",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
       //     migrationBuilder.CreateTable(
       //         name: "Events",
       //         columns: table => new
       //         {
       //             Id = table.Column<int>(type: "int", nullable: false)
       //                 .Annotation("SqlServer:Identity", "1, 1"),
       //             Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Date = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
       //             Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
       //             OurProgramId = table.Column<int>(type: "int", nullable: false)
       //         },
       //         constraints: table =>
       //         {
       //             table.PrimaryKey("PK_Events", x => x.Id);
       //             table.ForeignKey(
       //                 name: "FK_Events_OurProgram_OurProgramId",
       //                 column: x => x.OurProgramId,
       //                 principalTable: "OurProgram",
       //                 principalColumn: "Id",
       //                 onDelete: ReferentialAction.Cascade);
       //         });
       //
        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_RoleId",
        //        table: "AspNetRoleClaims",
        //        column: "RoleId");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "RoleNameIndex",
        //        table: "AspNetRoles",
        //        column: "NormalizedName",
        //        unique: true,
        //        filter: "[NormalizedName] IS NOT NULL");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserClaims_UserId",
        //        table: "AspNetUserClaims",
        //        column: "UserId");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_UserId",
        //        table: "AspNetUserLogins",
        //        column: "UserId");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_RoleId",
        //        table: "AspNetUserRoles",
        //        column: "RoleId");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "EmailIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedEmail");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "UserNameIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedUserName",
        //        unique: true,
        //        filter: "[NormalizedUserName] IS NOT NULL");
        //
        //    migrationBuilder.CreateIndex(
        //        name: "IX_Events_OurProgramId",
        //        table: "Events",
        //        column: "OurProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Center");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "ViewUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OurProgram");
        }
    }
}
