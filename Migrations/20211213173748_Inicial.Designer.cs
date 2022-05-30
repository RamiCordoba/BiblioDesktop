﻿// <auto-generated />
using System;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BiblioDesktop.Migrations
{
    [DbContext(typeof(BiblioDesktopContext))]
    [Migration("20211213173748_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiblioDesktop.Models.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("TematicaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TematicaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autor = "Nik",
                            Editorial = "Ediciones de la Flor",
                            Eliminado = false,
                            TematicaId = 10,
                            Titulo = "Gaturro"
                        },
                        new
                        {
                            Id = 2,
                            Autor = "Gabriel García Marquez",
                            Editorial = "Sudamericana",
                            Eliminado = false,
                            TematicaId = 12,
                            Titulo = "Cien años de Soledad"
                        },
                        new
                        {
                            Id = 3,
                            Autor = "El Rubius",
                            Editorial = "Martínez Roca",
                            Eliminado = false,
                            TematicaId = 11,
                            Titulo = "Virtual Hero"
                        },
                        new
                        {
                            Id = 4,
                            Autor = "Pepo",
                            Editorial = "Zig-Zag",
                            Eliminado = false,
                            TematicaId = 8,
                            Titulo = "Condorito"
                        },
                        new
                        {
                            Id = 5,
                            Autor = "Scott McCloud",
                            Editorial = "Tundra Publishing",
                            Eliminado = false,
                            TematicaId = 2,
                            Titulo = "Entender el Cómic"
                        },
                        new
                        {
                            Id = 6,
                            Autor = "Luisito Comunica",
                            Editorial = "Alfaguara Infantil Juvenil",
                            Eliminado = false,
                            TematicaId = 9,
                            Titulo = "Lugares Asombrosos"
                        },
                        new
                        {
                            Id = 7,
                            Autor = "José Hernandez",
                            Editorial = "Imprenta de la Pampa",
                            Eliminado = false,
                            TematicaId = 4,
                            Titulo = "Martín Fierro"
                        },
                        new
                        {
                            Id = 8,
                            Autor = "Felipe Pigna",
                            Editorial = "Booket",
                            Eliminado = false,
                            TematicaId = 14,
                            Titulo = "La Voz del Gran Jefe"
                        },
                        new
                        {
                            Id = 9,
                            Autor = "Quino",
                            Editorial = "El Mundo",
                            Eliminado = false,
                            TematicaId = 8,
                            Titulo = "Mafalda"
                        },
                        new
                        {
                            Id = 10,
                            Autor = "Suzanne Collins",
                            Editorial = "Scholastic Corporation",
                            Eliminado = false,
                            TematicaId = 1,
                            Titulo = "Los Juegos del Hambre"
                        });
                });

            modelBuilder.Entity("BiblioDesktop.Models.Prestamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRetiro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.Property<bool>("LibroDevuelto")
                        .HasColumnType("bit");

                    b.Property<int?>("LibroId")
                        .HasColumnType("int");

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.HasIndex("SocioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Prestamos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            FechaEntrega = new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRetiro = new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdLibro = 1,
                            LibroDevuelto = false,
                            SocioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            FechaEntrega = new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRetiro = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdLibro = 2,
                            LibroDevuelto = true,
                            SocioId = 2
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            FechaEntrega = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRetiro = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdLibro = 3,
                            LibroDevuelto = false,
                            SocioId = 3
                        },
                        new
                        {
                            Id = 4,
                            Eliminado = false,
                            FechaEntrega = new DateTime(2020, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRetiro = new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdLibro = 4,
                            LibroDevuelto = true,
                            SocioId = 4
                        },
                        new
                        {
                            Id = 5,
                            Eliminado = false,
                            FechaEntrega = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaRetiro = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdLibro = 5,
                            LibroDevuelto = false,
                            SocioId = 5
                        });
                });

            modelBuilder.Entity("BiblioDesktop.Models.Socio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Socios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Córdoba",
                            Dni = 39541236,
                            Domicilio = "20 de Junio 650",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1997, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Facundo",
                            Telefono = 3498561561.0
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Colombo",
                            Dni = 35698741,
                            Domicilio = "Independencia 2500",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1995, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan Pablo",
                            Telefono = 3425100321.0
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Valle",
                            Dni = 36541258,
                            Domicilio = "9 de Julio 1550",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos Iván",
                            Telefono = 3498123456.0
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Sabino",
                            Dni = 41236547,
                            Domicilio = "25 de Mayo 2511",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Matías",
                            Telefono = 3498741258.0
                        },
                        new
                        {
                            Id = 5,
                            Apellido = "Tibaldo",
                            Dni = 42856321,
                            Domicilio = "Rivadavia 650",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Agustín",
                            Telefono = 3498789456.0
                        });
                });

            modelBuilder.Entity("BiblioDesktop.Models.Tematica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tematicas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "Ciencia Ficción"
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Cómic y Manga"
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Nombre = "Fantasía"
                        },
                        new
                        {
                            Id = 4,
                            Eliminado = false,
                            Nombre = "Poesía"
                        },
                        new
                        {
                            Id = 5,
                            Eliminado = false,
                            Nombre = "Teatro"
                        },
                        new
                        {
                            Id = 6,
                            Eliminado = false,
                            Nombre = "Cocina"
                        },
                        new
                        {
                            Id = 7,
                            Eliminado = false,
                            Nombre = "Autoayuda"
                        },
                        new
                        {
                            Id = 8,
                            Eliminado = false,
                            Nombre = "Humor"
                        },
                        new
                        {
                            Id = 9,
                            Eliminado = false,
                            Nombre = "Viajes"
                        },
                        new
                        {
                            Id = 10,
                            Eliminado = false,
                            Nombre = "Infantil"
                        },
                        new
                        {
                            Id = 11,
                            Eliminado = false,
                            Nombre = "Juvenil"
                        },
                        new
                        {
                            Id = 12,
                            Eliminado = false,
                            Nombre = "Literatura Contemporánea"
                        },
                        new
                        {
                            Id = 13,
                            Eliminado = false,
                            Nombre = "Arte"
                        },
                        new
                        {
                            Id = 14,
                            Eliminado = false,
                            Nombre = "Historia"
                        },
                        new
                        {
                            Id = 15,
                            Eliminado = false,
                            Nombre = "Filosofía"
                        },
                        new
                        {
                            Id = 16,
                            Eliminado = false,
                            Nombre = "Historieta"
                        });
                });

            modelBuilder.Entity("BiblioDesktop.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaHoraEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "admin",
                            Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            TipoUsuario = 1,
                            User = "admin"
                        });
                });

            modelBuilder.Entity("BiblioDesktop.Models.Libro", b =>
                {
                    b.HasOne("BiblioDesktop.Models.Tematica", "Tematica")
                        .WithMany()
                        .HasForeignKey("TematicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BiblioDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BiblioDesktop.Models.Prestamo", b =>
                {
                    b.HasOne("BiblioDesktop.Models.Libro", "Libro")
                        .WithMany("Prestamos")
                        .HasForeignKey("LibroId");

                    b.HasOne("BiblioDesktop.Models.Socio", "Socio")
                        .WithMany("Prestamos")
                        .HasForeignKey("SocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BiblioDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BiblioDesktop.Models.Socio", b =>
                {
                    b.HasOne("BiblioDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BiblioDesktop.Models.Tematica", b =>
                {
                    b.HasOne("BiblioDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("BiblioDesktop.Models.Usuario", b =>
                {
                    b.HasOne("BiblioDesktop.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId1");
                });
#pragma warning restore 612, 618
        }
    }
}