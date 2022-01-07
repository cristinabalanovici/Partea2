﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Partea2.Data;

namespace Partea2.Migrations
{
    [DbContext(typeof(Partea2Context))]
    [Migration("20220107135303_Client")]
    partial class Client
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Partea2.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Partea2.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataProgramarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramareID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProgramareID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Partea2.Models.Programare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumarulProgramarii")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientId");

                    b.ToTable("Programare");
                });

            modelBuilder.Entity("Partea2.Models.Client", b =>
                {
                    b.HasOne("Partea2.Models.Doctor", "Doctor")
                        .WithMany("Client")
                        .HasForeignKey("DoctorID");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Partea2.Models.Doctor", b =>
                {
                    b.HasOne("Partea2.Models.Programare", "Programare")
                        .WithMany()
                        .HasForeignKey("ProgramareID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Programare");
                });

            modelBuilder.Entity("Partea2.Models.Programare", b =>
                {
                    b.HasOne("Partea2.Models.Client", null)
                        .WithMany("Programare")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Partea2.Models.Client", b =>
                {
                    b.Navigation("Programare");
                });

            modelBuilder.Entity("Partea2.Models.Doctor", b =>
                {
                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}