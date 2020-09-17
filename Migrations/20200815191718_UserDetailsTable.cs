using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteServerAccess.Migrations
{
    public partial class UserDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemoteServerAccessInfo",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(nullable: true),
                    USER_S_ACCESS_BY = table.Column<string>(nullable: true),
                    ISACTIVE_S = table.Column<bool>(nullable: false),
                    USER_P_ACCESS_BY = table.Column<string>(nullable: true),
                    ISACTIVE_P = table.Column<bool>(nullable: false),
                    DateTimeStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoteServerAccessInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    SystemUserName = table.Column<string>(nullable: true),
                    DateTimeStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemoteServerAccessInfo");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
