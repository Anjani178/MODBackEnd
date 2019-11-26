﻿// <auto-generated />
using MOD.TechnologyService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.TechnologyService.Migrations
{
    [DbContext(typeof(TechnoContext))]
    [Migration("20191121103616_InitialSkills")]
    partial class InitialSkills
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.TechnologyService.Models.Skill", b =>
                {
                    b.Property<string>("SId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Fees")
                        .HasColumnType("float");

                    b.Property<string>("PreReq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("toc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}