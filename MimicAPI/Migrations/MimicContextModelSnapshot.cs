﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MimicAPI.Database;
using System;

namespace MimicAPI.Migrations
{
    [DbContext(typeof(MimicContext))]
    partial class MimicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("MimicAPI.Models.Palavra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("Atualizado");

                    b.Property<DateTime>("Criado");

                    b.Property<string>("Nome");

                    b.Property<int>("Pontuacao");

                    b.HasKey("Id");

                    b.ToTable("Palavras");
                });
#pragma warning restore 612, 618
        }
    }
}
