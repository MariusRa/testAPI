﻿// <auto-generated />
using System;
using LLMS.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LLMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LLMS.Models.LearningLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LearningLanguages");
                });

            modelBuilder.Entity("LLMS.Models.LearningSemester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LearningSemesters");
                });

            modelBuilder.Entity("LLMS.Models.LearningTarget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LearningTargets");
                });

            modelBuilder.Entity("LLMS.Models.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CostCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("RequestorUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("SemesterId")
                        .HasColumnType("int");

                    b.Property<string>("Student")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TargetId")
                        .HasColumnType("int");

                    b.HasKey("RequestId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("RequestorUserId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("TargetId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("LLMS.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LLMS.Models.Request", b =>
                {
                    b.HasOne("LLMS.Models.LearningLanguage", "Language")
                        .WithMany("ReaquestLanguage")
                        .HasForeignKey("LanguageId");

                    b.HasOne("LLMS.Models.User", "Requestor")
                        .WithMany("UserRequests")
                        .HasForeignKey("RequestorUserId");

                    b.HasOne("LLMS.Models.LearningSemester", "Semester")
                        .WithMany("RequestSemester")
                        .HasForeignKey("SemesterId");

                    b.HasOne("LLMS.Models.LearningTarget", "Target")
                        .WithMany("RequestTarget")
                        .HasForeignKey("TargetId");

                    b.Navigation("Language");

                    b.Navigation("Requestor");

                    b.Navigation("Semester");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("LLMS.Models.LearningLanguage", b =>
                {
                    b.Navigation("ReaquestLanguage");
                });

            modelBuilder.Entity("LLMS.Models.LearningSemester", b =>
                {
                    b.Navigation("RequestSemester");
                });

            modelBuilder.Entity("LLMS.Models.LearningTarget", b =>
                {
                    b.Navigation("RequestTarget");
                });

            modelBuilder.Entity("LLMS.Models.User", b =>
                {
                    b.Navigation("UserRequests");
                });
#pragma warning restore 612, 618
        }
    }
}