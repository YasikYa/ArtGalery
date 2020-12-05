using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGaleryEF.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FameStatus", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("2a8dd830-5d6d-4daa-90c1-1a64d762c513"), 0, "Lui", "Grojan" },
                    { new Guid("0de3fee1-b15e-49ce-a27b-3e407b2fd22e"), 0, "Bart", "Tompson" },
                    { new Guid("00647c54-f2d1-44bf-86fc-6aa12293c3e8"), 1, "Jorje", "Vinnor" },
                    { new Guid("69342729-22f1-4722-923f-61c2767f60b8"), 1, "Alex", "Veltor" },
                    { new Guid("0458d15a-f5b0-43e3-a9e9-b3111708d4f6"), 1, "Elenea", "Bortwik" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "Age", "Title" },
                values: new object[,]
                {
                    { new Guid("3af05d14-732f-4229-8a76-a56c761e71a7"), 89, "The Persistence of Memory" },
                    { new Guid("40642f1a-642c-4a8f-9143-fc3e40349bbf"), 515, "Ritratto di Monna Lisa del Giocondo" },
                    { new Guid("f158c347-e9b5-40b4-93ad-dfb3ff95f1cf"), 131, "De sterrennacht" },
                    { new Guid("9772e4c2-2123-49fc-8fcf-5725050e7b8a"), 139, "Богатыри" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("00647c54-f2d1-44bf-86fc-6aa12293c3e8"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("0458d15a-f5b0-43e3-a9e9-b3111708d4f6"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("0de3fee1-b15e-49ce-a27b-3e407b2fd22e"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("2a8dd830-5d6d-4daa-90c1-1a64d762c513"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("69342729-22f1-4722-923f-61c2767f60b8"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("3af05d14-732f-4229-8a76-a56c761e71a7"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("40642f1a-642c-4a8f-9143-fc3e40349bbf"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("9772e4c2-2123-49fc-8fcf-5725050e7b8a"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("f158c347-e9b5-40b4-93ad-dfb3ff95f1cf"));
        }
    }
}
