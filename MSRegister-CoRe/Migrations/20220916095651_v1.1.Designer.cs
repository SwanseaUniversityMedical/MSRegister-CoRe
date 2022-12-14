// <auto-generated />
using System;
using MSRegister_CoRe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MSRegister_CoRe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220916095651_v1.1")]
    partial class v11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MSRegister_CoRe.Models.Root", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("BirthGender")
                        .HasColumnType("text");

                    b.Property<string>("Device")
                        .HasColumnType("text");

                    b.Property<string>("DominantHand")
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<string>("StudyId")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Root");
                });

            modelBuilder.Entity("MSRegister_CoRe.Models.Score", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("text");

                    b.Property<int>("CurrentScore")
                        .HasColumnType("integer");

                    b.Property<string>("DeviceOrientation")
                        .HasColumnType("text");

                    b.Property<int>("Question")
                        .HasColumnType("integer");

                    b.Property<string>("ScoreStamp")
                        .HasColumnType("text");

                    b.Property<string>("SymbolChoice")
                        .HasColumnType("text");

                    b.Property<int?>("TestID")
                        .HasColumnType("integer");

                    b.Property<string>("TimeRemaining")
                        .HasColumnType("text");

                    b.Property<string>("VoiceCommand")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("TestID");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("MSRegister_CoRe.Models.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EndStamp")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfQuestions")
                        .HasColumnType("integer");

                    b.Property<int?>("RootID")
                        .HasColumnType("integer");

                    b.Property<int>("SuccessfulAnswers")
                        .HasColumnType("integer");

                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.HasKey("TestID");

                    b.HasIndex("RootID");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("MSRegister_CoRe.Models.Score", b =>
                {
                    b.HasOne("MSRegister_CoRe.Models.Test", null)
                        .WithMany("Scores")
                        .HasForeignKey("TestID");
                });

            modelBuilder.Entity("MSRegister_CoRe.Models.Test", b =>
                {
                    b.HasOne("MSRegister_CoRe.Models.Root", null)
                        .WithMany("Tests")
                        .HasForeignKey("RootID");
                });
#pragma warning restore 612, 618
        }
    }
}
