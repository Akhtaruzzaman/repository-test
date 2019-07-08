using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class V001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFrom = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedFrom = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Others = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
