﻿// <auto-generated />
using System;
using EAPN.HDVS.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EAPN.HDVS.Web.Migrations
{
    [DbContext(typeof(HDVSContext))]
    partial class HDVSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EAPN.HDVS.Entities.Ficha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .HasColumnName("Apellido1")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Apellido2")
                        .HasColumnName("Apellido2")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("CP")
                        .HasColumnName("CP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Completa")
                        .HasColumnName("Completa")
                        .HasColumnType("bit");

                    b.Property<string>("DNI")
                        .HasColumnName("DNI")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<bool>("DocumentacionEmpadronamiento")
                        .HasColumnName("DocumentacionEmpadronamiento")
                        .HasColumnType("bit");

                    b.Property<string>("Domicilio")
                        .HasColumnName("Domicilio")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnName("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnName("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FotocopiaDNI")
                        .HasColumnName("FotocopiaDNI")
                        .HasColumnType("bit");

                    b.Property<int?>("GeneroId")
                        .HasColumnName("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("MotivoAlta")
                        .HasColumnName("MotivoAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnName("MunicipioId")
                        .HasColumnType("int");

                    b.Property<int?>("NacionalidadId")
                        .HasColumnName("NacionalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Observaciones")
                        .HasColumnName("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizacionId")
                        .HasColumnName("OrganizacionId")
                        .HasColumnType("int");

                    b.Property<int?>("OrigenId")
                        .HasColumnName("OrigenId")
                        .HasColumnType("int");

                    b.Property<int?>("PadronId")
                        .HasColumnName("PadronId")
                        .HasColumnType("int");

                    b.Property<bool>("PoliticaFirmada")
                        .HasColumnName("PoliticaFirmada")
                        .HasColumnType("bit");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnName("ProvinciaId")
                        .HasColumnType("int");

                    b.Property<int?>("SexoId")
                        .HasColumnName("SexoId")
                        .HasColumnType("int");

                    b.Property<int?>("SituacionAdministrativaId")
                        .HasColumnName("SituacionAdministrativaId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnName("Telefono")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("NacionalidadId");

                    b.HasIndex("OrganizacionId");

                    b.HasIndex("OrigenId");

                    b.HasIndex("PadronId");

                    b.HasIndex("ProvinciaId");

                    b.HasIndex("SexoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Fichas","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallSite")
                        .HasColumnName("CallSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnName("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exception")
                        .HasColumnName("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnName("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnName("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelOrder")
                        .HasColumnName("LevelOrder")
                        .HasColumnType("int");

                    b.Property<string>("Logger")
                        .HasColumnName("Logger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnName("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Logs","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProvinciaId")
                        .HasColumnName("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Municipios","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Organizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activa")
                        .HasColumnName("Activa")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnName("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Observaciones")
                        .HasColumnName("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnName("Telefono")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Web")
                        .HasColumnName("Web")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Organizaciones","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Paises","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Perfiles","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.PerfilPermiso", b =>
                {
                    b.Property<int>("PerfilId")
                        .HasColumnName("PerfilId")
                        .HasColumnType("int");

                    b.Property<int>("PermisoId")
                        .HasColumnName("PermisoId")
                        .HasColumnType("int");

                    b.HasKey("PerfilId", "PermisoId");

                    b.HasIndex("PermisoId");

                    b.ToTable("PerfilesPermisos","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("Clave")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Permisos","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Provincias","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FinValidez")
                        .HasColumnName("FinValidez")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnName("Token")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RefreshTokens","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Sexo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sexos","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnName("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellidos")
                        .HasColumnName("Apellidos")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnName("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinBloqueo")
                        .HasColumnName("FinBloqueo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("Hash")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("IntentosLogin")
                        .HasColumnName("IntentosLogin")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Observaciones")
                        .HasColumnName("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizacionId")
                        .HasColumnName("OrganizacionId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnName("Telefono")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UltimoAcceso")
                        .HasColumnName("UltimoAcceso")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrganizacionId");

                    b.ToTable("Usuarios","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.UsuarioPerfil", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("PerfilId")
                        .HasColumnName("PerfilId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "PerfilId");

                    b.HasIndex("PerfilId");

                    b.ToTable("UsuariosPerfiles","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.UsuarioPermiso", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnName("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("PermisoId")
                        .HasColumnName("PermisoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "PermisoId");

                    b.HasIndex("PermisoId");

                    b.ToTable("UsuariosPermisos","dbo");
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Ficha", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Sexo", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Pais", "Nacionalidad")
                        .WithMany()
                        .HasForeignKey("NacionalidadId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Organizacion", "Organizacion")
                        .WithMany()
                        .HasForeignKey("OrganizacionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EAPN.HDVS.Entities.Pais", "Origen")
                        .WithMany()
                        .HasForeignKey("OrigenId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Municipio", "Padron")
                        .WithMany()
                        .HasForeignKey("PadronId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Sexo", "Sexo")
                        .WithMany()
                        .HasForeignKey("SexoId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("EAPN.HDVS.Entities.Usuario", "Tecnico")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Municipio", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Provincia", "Provincia")
                        .WithMany("Municipios")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.PerfilPermiso", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Perfil", "Perfil")
                        .WithMany("Permisos")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EAPN.HDVS.Entities.Permiso", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.RefreshToken", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Usuario", "Usuario")
                        .WithMany("Tokens")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.Usuario", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Organizacion", "Organizacion")
                        .WithMany("Usuarios")
                        .HasForeignKey("OrganizacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.UsuarioPerfil", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EAPN.HDVS.Entities.Usuario", "Usuario")
                        .WithMany("Perfiles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EAPN.HDVS.Entities.UsuarioPermiso", b =>
                {
                    b.HasOne("EAPN.HDVS.Entities.Permiso", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EAPN.HDVS.Entities.Usuario", "Usuario")
                        .WithMany("PermisosAdicionales")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
