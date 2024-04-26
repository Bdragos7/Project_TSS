using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_DAW_Cinemavazut.Migrations
{
    /// <inheritdoc />
    public partial class CurrentVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    id_achievement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categorie_ach = table.Column<int>(type: "int", nullable: false),
                    prag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.id_achievement);
                });

            migrationBuilder.CreateTable(
                name: "Categorii_filme",
                columns: table => new
                {
                    id_categorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorii_filme", x => x.id_categorie);
                });

            migrationBuilder.CreateTable(
                name: "FilmCategorie",
                columns: table => new
                {
                    id_filmcategorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_film = table.Column<int>(type: "int", nullable: false),
                    id_categorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmCategorie", x => x.id_filmcategorie);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    id_film = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titlu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    an_lansare = table.Column<int>(type: "int", nullable: true),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    studio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durata = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.id_film);
                });

            migrationBuilder.CreateTable(
                name: "Filme_urmatoare",
                columns: table => new
                {
                    id_urmatoare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentariu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_film = table.Column<int>(type: "int", nullable: false),
                    id_utilizator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme_urmatoare", x => x.id_urmatoare);
                });

            migrationBuilder.CreateTable(
                name: "Filme_vazute",
                columns: table => new
                {
                    id_vazute = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentariu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    favorit = table.Column<bool>(type: "bit", nullable: false),
                    id_film = table.Column<int>(type: "int", nullable: false),
                    id_utilizator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme_vazute", x => x.id_vazute);
                });

            migrationBuilder.CreateTable(
                name: "Quizuri",
                columns: table => new
                {
                    id_quiz = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_film = table.Column<int>(type: "int", nullable: false),
                    intrebare1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns1_corect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns1_gresit1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns1_gresit2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intrebare2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns2_corect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns2_gresit1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raspuns2_gresit2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intrebare3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns3_corect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns3_gresit1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns3_gresit2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intrebare4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns4_corect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns4_gresit1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns4_gresit2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intrebare5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns5_corect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns5_gresit1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raspuns5_gresit2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizuri", x => x.id_quiz);
                });

            migrationBuilder.CreateTable(
                name: "Quizuri_trecute",
                columns: table => new
                {
                    id_quizuri_trecute = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_quiz = table.Column<int>(type: "int", nullable: false),
                    id_utilizator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizuri_trecute", x => x.id_quizuri_trecute);
                });

            migrationBuilder.CreateTable(
                name: "Recenzii",
                columns: table => new
                {
                    id_recenzie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titlu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comentariu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: false),
                    id_film = table.Column<int>(type: "int", nullable: false),
                    id_utilizator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzii", x => x.id_recenzie);
                });

            migrationBuilder.CreateTable(
                name: "UtilizatorAchievement",
                columns: table => new
                {
                    id_utilizatorachievement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_utilizator = table.Column<int>(type: "int", nullable: false),
                    id_achievement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilizatorAchievement", x => x.id_utilizatorachievement);
                });

            migrationBuilder.CreateTable(
                name: "Utilizatori",
                columns: table => new
                {
                    id_utilizator = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nastere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_inscriere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rol = table.Column<int>(type: "int", nullable: false),
                    scor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizatori", x => x.id_utilizator);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Categorii_filme");

            migrationBuilder.DropTable(
                name: "FilmCategorie");

            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Filme_urmatoare");

            migrationBuilder.DropTable(
                name: "Filme_vazute");

            migrationBuilder.DropTable(
                name: "Quizuri");

            migrationBuilder.DropTable(
                name: "Quizuri_trecute");

            migrationBuilder.DropTable(
                name: "Recenzii");

            migrationBuilder.DropTable(
                name: "UtilizatorAchievement");

            migrationBuilder.DropTable(
                name: "Utilizatori");
        }
    }
}
