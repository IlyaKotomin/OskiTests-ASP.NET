﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OskiTests.Data;

#nullable disable

namespace OskiTests.Migrations
{
    [DbContext(typeof(AppDataBaseContext))]
    [Migration("20221207155737_RenameProps")]
    partial class RenameProps
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OskiTests.Models.AnswerViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionViewModelId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("OskiTests.Models.QuestionViewModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizViewModelId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("OskiTests.Models.QuizViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserViewModelId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("OskiTests.Models.UserViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AltName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OskiTests.Models.AnswerViewModel", b =>
                {
                    b.HasOne("OskiTests.Models.QuestionViewModel", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionViewModelId");
                });

            modelBuilder.Entity("OskiTests.Models.QuestionViewModel", b =>
                {
                    b.HasOne("OskiTests.Models.QuizViewModel", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuizViewModelId");
                });

            modelBuilder.Entity("OskiTests.Models.QuizViewModel", b =>
                {
                    b.HasOne("OskiTests.Models.UserViewModel", null)
                        .WithMany("CompliteQuizzes")
                        .HasForeignKey("UserViewModelId");
                });

            modelBuilder.Entity("OskiTests.Models.QuestionViewModel", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("OskiTests.Models.QuizViewModel", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("OskiTests.Models.UserViewModel", b =>
                {
                    b.Navigation("CompliteQuizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
