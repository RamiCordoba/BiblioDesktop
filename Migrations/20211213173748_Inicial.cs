using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BiblioDesktop.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Imagen = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tematicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tematicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tematicas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    Autor = table.Column<string>(nullable: false),
                    Editorial = table.Column<string>(nullable: false),
                    Imagen = table.Column<byte[]>(nullable: true),
                    TematicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_Tematicas_TematicaId",
                        column: x => x.TematicaId,
                        principalTable: "Tematicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libros_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    FechaRetiro = table.Column<DateTime>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: false),
                    SocioId = table.Column<int>(nullable: false),
                    IdLibro = table.Column<int>(nullable: false),
                    LibroId = table.Column<int>(nullable: true),
                    LibroDevuelto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamos_Socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "Id", "Apellido", "Dni", "Domicilio", "Eliminado", "FechaHoraEliminacion", "FechaNacimiento", "Imagen", "Nombre", "Telefono", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Córdoba", 39541236, "20 de Junio 650", false, null, new DateTime(1997, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Facundo", 3498561561.0, null },
                    { 2, "Colombo", 35698741, "Independencia 2500", false, null, new DateTime(1995, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Juan Pablo", 3425100321.0, null },
                    { 3, "Valle", 36541258, "9 de Julio 1550", false, null, new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carlos Iván", 3498123456.0, null },
                    { 4, "Sabino", 41236547, "25 de Mayo 2511", false, null, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Matías", 3498741258.0, null },
                    { 5, "Tibaldo", 42856321, "Rivadavia 650", false, null, new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agustín", 3498789456.0, null }
                });

            migrationBuilder.InsertData(
                table: "Tematicas",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "UsuarioId" },
                values: new object[,]
                {
                    { 15, false, null, "Filosofía", null },
                    { 14, false, null, "Historia", null },
                    { 13, false, null, "Arte", null },
                    { 12, false, null, "Literatura Contemporánea", null },
                    { 11, false, null, "Juvenil", null },
                    { 10, false, null, "Infantil", null },
                    { 9, false, null, "Viajes", null },
                    { 6, false, null, "Cocina", null },
                    { 7, false, null, "Autoayuda", null },
                    { 16, false, null, "Historieta", null },
                    { 5, false, null, "Teatro", null },
                    { 4, false, null, "Poesía", null },
                    { 3, false, null, "Fantasía", null },
                    { 2, false, null, "Cómic y Manga", null },
                    { 1, false, null, "Ciencia Ficción", null },
                    { 8, false, null, "Humor", null }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Eliminado", "FechaHoraEliminacion", "Nombre", "Password", "TipoUsuario", "User", "UsuarioId", "UsuarioId1" },
                values: new object[] { 1, false, null, "admin", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 1, "admin", null, null });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "Autor", "Editorial", "Eliminado", "FechaHoraEliminacion", "Imagen", "TematicaId", "Titulo", "UsuarioId" },
                values: new object[,]
                {
                    { 10, "Suzanne Collins", "Scholastic Corporation", false, null, null, 1, "Los Juegos del Hambre", null },
                    { 5, "Scott McCloud", "Tundra Publishing", false, null, null, 2, "Entender el Cómic", null },
                    { 7, "José Hernandez", "Imprenta de la Pampa", false, null, null, 4, "Martín Fierro", null },
                    { 4, "Pepo", "Zig-Zag", false, null, null, 8, "Condorito", null },
                    { 9, "Quino", "El Mundo", false, null, null, 8, "Mafalda", null },
                    { 6, "Luisito Comunica", "Alfaguara Infantil Juvenil", false, null, null, 9, "Lugares Asombrosos", null },
                    { 1, "Nik", "Ediciones de la Flor", false, null, null, 10, "Gaturro", null },
                    { 3, "El Rubius", "Martínez Roca", false, null, null, 11, "Virtual Hero", null },
                    { 2, "Gabriel García Marquez", "Sudamericana", false, null, null, 12, "Cien años de Soledad", null },
                    { 8, "Felipe Pigna", "Booket", false, null, null, 14, "La Voz del Gran Jefe", null }
                });

            migrationBuilder.InsertData(
                table: "Prestamos",
                columns: new[] { "Id", "Eliminado", "FechaEntrega", "FechaHoraEliminacion", "FechaRetiro", "IdLibro", "LibroDevuelto", "LibroId", "SocioId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, 1, null },
                    { 2, false, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, null, 2, null },
                    { 3, false, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, null, 3, null },
                    { 4, false, new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, null, 4, null },
                    { 5, false, new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, null, 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_TematicaId",
                table: "Libros",
                column: "TematicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_UsuarioId",
                table: "Libros",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LibroId",
                table: "Prestamos",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_SocioId",
                table: "Prestamos",
                column: "SocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_UsuarioId",
                table: "Prestamos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_UsuarioId",
                table: "Socios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tematicas_UsuarioId",
                table: "Tematicas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Socios");

            migrationBuilder.DropTable(
                name: "Tematicas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
