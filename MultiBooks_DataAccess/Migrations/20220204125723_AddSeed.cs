using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiBooks_DataAccess.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorDetail_Id", "FirstName", "LastName", "MentorId" },
                values: new object[,]
                {
                    { 5, null, "Bernard", "Turgeon", null },
                    { 7, null, "Agatha", "Christie", null }
                });

            migrationBuilder.InsertData(
                table: "AuthorDetail",
                columns: new[] { "Id", "Biography", "Photo" },
                values: new object[,]
                {
                    { 1, "Né au Caire, diplômé en traduction et en littérature française, Elie Hanson est un globe-trotter qui a vécu sur quatre continents, avant de finalement s’installer à Montréal. Il a reçu la Médaille du jubilé de diamant de la reine Elizabeth II avec la première édition de son roman Le carnet maudit. Mission Arctik est son cinquième roman.", "" },
                    { 2, "Originaire de St-Hyacinthe, Vincent Fournier-Boisvert est musicien et enseignant. Il a joué pour Cavalia et dans des groupes de trad, de free jazz et de black métal. Le puits est son premier roman.", "" },
                    { 3, "Conseiller informatique résidant à Québec, Guy Bergeron a connu un succès considérable avec La trilogie de l’Orbe et sa fresque L’Héritière de Ferrolia. Après Coeur de Givre et Les âmes perdues, deux récits de la série Légendes d’Arménis, il a adapté à sa manière les grands classiques homériques avec Fils de Troie et Le retour d’Ulysse. Avec Évelyne est morte, il change de registre littéraire et signe un polar fantastique impeccable confirmant l’étendue de son talent.", "" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name", "PublisherSite", "Speciality" },
                values: new object[,]
                {
                    { 1, "ADA", "www.ada-inc.com", "Jeunesse, croissance personnelle" },
                    { 2, "Chenelière", "www.cheneliere.ca", "Éducation, collégial, universitaire" },
                    { 3, "Livre de poche", "www.livredepoche.com", "Drame, policier, biographie" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Droits" },
                    { 6, "Fantastique" },
                    { 5, "Romance" },
                    { 1, "Policier" },
                    { 3, "Mystère" },
                    { 2, "Drame" },
                    { 8, "Thriller" },
                    { 4, "Ressources humaines" },
                    { 9, "Biographie" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorDetail_Id", "FirstName", "LastName", "MentorId" },
                values: new object[,]
                {
                    { 6, null, "Dominic", "Lamaute", 5 },
                    { 4, null, "Kim", "Messier", 7 },
                    { 1, 1, "Elie", "Hanson", null },
                    { 3, 3, "Guy", "Bergeron", null }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Available", "ISBN", "Price", "PublishedDate", "Publisher_Id", "Subject_Id", "Title" },
                values: new object[,]
                {
                    { 2, true, "9782898190001", 19.95m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Le puit" },
                    { 7, true, "9782253167129", 22m, new DateTime(1920, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "Affaires de styles" },
                    { 8, true, "9782253167130", 24m, new DateTime(1937, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "Témoins muets" },
                    { 9, true, "9782253177753", 18.55m, new DateTime(1938, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "Le Noël d Hercule Poirot" },
                    { 5, true, "9782765045281", 61.95m, new DateTime(2017, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "De la supervision à la gestion des ressources humaines" },
                    { 6, true, "9782765051527", 59.95m, new DateTime(2016, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "Le management - À l ère des technologies de l information" },
                    { 1, true, "9782898190063", 19.95m, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "Mission Arctik" },
                    { 3, true, "9782898032752", 19.95m, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "Menvatts-valse macabre" },
                    { 4, true, "9782898032813", 19.95m, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "Menvatts-Uncia" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorDetail_Id", "FirstName", "LastName", "MentorId" },
                values: new object[] { 2, 2, "Vincent", "Fournier-Boisvert", 1 });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "Author_Id", "Book_Id" },
                values: new object[,]
                {
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 5, 5 },
                    { 6, 5 },
                    { 5, 6 },
                    { 6, 6 },
                    { 1, 1 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "Author_Id", "Book_Id" },
                values: new object[] { 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "Author_Id", "Book_Id" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AuthorDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuthorDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AuthorDetail",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
