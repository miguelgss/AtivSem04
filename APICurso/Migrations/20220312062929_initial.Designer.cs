﻿// <auto-generated />
using APICurso.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APICurso.Migrations
{
    [DbContext(typeof(CursoContext))]
    [Migration("20220312062929_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("APICurso.Models.LimiteCliente", b =>
                {
                    b.Property<int>("LimiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("LimiteCredito")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("LimiteId");

                    b.ToTable("LimiteClientes");
                });
#pragma warning restore 612, 618
        }
    }
}