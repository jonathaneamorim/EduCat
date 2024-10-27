using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipoUsuario = table.Column<int>(type: "integer", nullable: false),
                    Matricula = table.Column<int>(type: "integer", nullable: false),
                    NomeCivil = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: true),
                    Genero = table.Column<int>(type: "integer", nullable: true),
                    Naturalidade = table.Column<string>(type: "text", nullable: true),
                    Raca = table.Column<int>(type: "integer", nullable: true),
                    TipoSanguineo = table.Column<int>(type: "integer", nullable: true),
                    Nacionalidade = table.Column<string>(type: "text", nullable: true),
                    EstadoCivil = table.Column<int>(type: "integer", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nivel = table.Column<int>(type: "integer", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    NomePai = table.Column<string>(type: "text", nullable: true),
                    NomeMae = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Logradouro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Numero = table.Column<int>(type: "integer", nullable: true),
                    Bairro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Municipio = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UF = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    Complemento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Pais = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
