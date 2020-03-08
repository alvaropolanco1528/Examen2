﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1.Data;

namespace Parcial1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Parcial1.Models.Inscripciones", b =>
                {
                    b.Property<int>("Matricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Limite")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Semestre")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tomados")
                        .HasColumnType("INTEGER");

                    b.HasKey("Matricula");

                    b.ToTable("Inscripciones");
                });
#pragma warning restore 612, 618
        }
    }
}