﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250427181654_MigracaoUmParaUm")]
    partial class MigracaoUmParaUm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("TB_ARMAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 35,
                            Nome = "Arco e Flecha",
                            PersonagemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dano = 33,
                            Nome = "Espada",
                            PersonagemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Dano = 31,
                            Nome = "Machado",
                            PersonagemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Dano = 30,
                            Nome = "Punho",
                            PersonagemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Dano = 34,
                            Nome = "Chicote",
                            PersonagemId = 5
                        },
                        new
                        {
                            Id = 6,
                            Dano = 33,
                            Nome = "Foice",
                            PersonagemId = 6
                        },
                        new
                        {
                            Id = 7,
                            Dano = 32,
                            Nome = "Cajado",
                            PersonagemId = 7
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_HABILIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 39,
                            Nome = "Paralizar"
                        },
                        new
                        {
                            Id = 2,
                            Dano = 41,
                            Nome = "Fritar"
                        },
                        new
                        {
                            Id = 3,
                            Dano = 37,
                            Nome = "Entrar na mente"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Derrotas")
                        .HasColumnType("int");

                    b.Property<int>("Disputas")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("Vitorias")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Derrotas = 0,
                            Disputas = 0,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100,
                            UsuarioId = 1,
                            Vitorias = 0
                        });
                });

            modelBuilder.Entity("RpgApi.Models.PersonagemHabilidade", b =>
                {
                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.Property<int>("HabilidadeId")
                        .HasColumnType("int");

                    b.HasKey("PersonagemId", "HabilidadeId");

                    b.HasIndex("HabilidadeId");

                    b.ToTable("TB_PERSONAGENS_HABILIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            PersonagemId = 1,
                            HabilidadeId = 1
                        },
                        new
                        {
                            PersonagemId = 1,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 2,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 3,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 3,
                            HabilidadeId = 3
                        },
                        new
                        {
                            PersonagemId = 4,
                            HabilidadeId = 3
                        },
                        new
                        {
                            PersonagemId = 5,
                            HabilidadeId = 1
                        },
                        new
                        {
                            PersonagemId = 6,
                            HabilidadeId = 2
                        },
                        new
                        {
                            PersonagemId = 7,
                            HabilidadeId = 3
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 234, 189, 227, 90, 144, 235, 15, 118, 192, 21, 22, 130, 103, 186, 56, 187, 76, 144, 27, 111, 230, 215, 246, 40, 102, 230, 14, 72, 54, 67, 213, 89, 9, 35, 56, 244, 100, 81, 66, 6, 250, 241, 111, 39, 239, 45, 188, 207, 107, 88, 229, 12, 96, 246, 144, 162, 200, 102, 1, 112, 235, 133, 97, 206 },
                            PasswordSalt = new byte[] { 49, 104, 228, 222, 63, 167, 205, 168, 227, 53, 159, 81, 12, 179, 226, 10, 99, 178, 146, 185, 63, 186, 182, 21, 117, 38, 46, 188, 251, 80, 208, 219, 3, 21, 215, 136, 58, 70, 37, 14, 223, 148, 153, 219, 71, 120, 187, 247, 248, 186, 105, 14, 81, 205, 19, 18, 26, 229, 233, 49, 63, 239, 221, 35, 110, 171, 108, 181, 203, 192, 236, 110, 35, 207, 200, 0, 123, 79, 137, 134, 15, 19, 186, 149, 71, 250, 125, 124, 169, 103, 198, 205, 11, 112, 87, 218, 35, 7, 160, 158, 188, 21, 49, 23, 67, 87, 97, 158, 44, 68, 59, 30, 23, 205, 104, 230, 21, 75, 202, 254, 23, 189, 73, 127, 75, 67, 121, 185 },
                            Perfil = "Admin",
                            Username = "userAdm"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithMany("Arma")
                        .HasForeignKey("PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.PersonagemHabilidade", b =>
                {
                    b.HasOne("RpgApi.Models.Habilidade", "Habilidade")
                        .WithMany()
                        .HasForeignKey("HabilidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithMany()
                        .HasForeignKey("PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habilidade");

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Navigation("Arma");
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
