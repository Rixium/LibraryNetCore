﻿using System;

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations {

    public partial class InitialMigration : Migration {

        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                "Patrons",
                table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Patrons", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                "Patrons");
        }

    }

}