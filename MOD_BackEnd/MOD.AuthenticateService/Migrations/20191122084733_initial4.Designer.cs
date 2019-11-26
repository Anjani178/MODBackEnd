﻿// <auto-generated />
using System;
using MOD.AuthenticateService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.AuthenticateService.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191122084733_initial4")]
    partial class initial4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.AuthenticateServic.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<float>("AmountMentor")
                        .HasColumnType("real");

                    b.Property<string>("Mid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Uid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PaymentId");

                    b.HasIndex("Mid");

                    b.HasIndex("TId");

                    b.HasIndex("Uid");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("MOD.AuthenticateServic.Models.Skill", b =>
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

            modelBuilder.Entity("MOD.AuthenticateServic.Models.Training", b =>
                {
                    b.Property<string>("TId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("CommissionFee")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("SId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeDuration")
                        .HasColumnType("int");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TId");

                    b.HasIndex("Mid");

                    b.HasIndex("SId");

                    b.HasIndex("Uid");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD.AuthenticateServic.Models.User", b =>
                {
                    b.Property<string>("Uid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Uid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MOD.AuthenticateService.Models.Mentor", b =>
                {
                    b.Property<string>("Mid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Facilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technologies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedinUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("yearOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Mid");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.AuthenticateServic.Models.Payment", b =>
                {
                    b.HasOne("MOD.AuthenticateService.Models.Mentor", "Mentor")
                        .WithMany("Payments")
                        .HasForeignKey("Mid");

                    b.HasOne("MOD.AuthenticateServic.Models.Training", "Training")
                        .WithMany("Payments")
                        .HasForeignKey("TId");

                    b.HasOne("MOD.AuthenticateServic.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("Uid");
                });

            modelBuilder.Entity("MOD.AuthenticateServic.Models.Training", b =>
                {
                    b.HasOne("MOD.AuthenticateService.Models.Mentor", "Mentor")
                        .WithMany("Trainings")
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.AuthenticateServic.Models.Skill", "Skills")
                        .WithMany("Training")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.AuthenticateServic.Models.User", "User")
                        .WithMany("Trainings")
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
