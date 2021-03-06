// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jeudontonestleheros.Core.Data;

namespace jeudontonestleheros.Core.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20200121144843_essai")]
    partial class essai
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Aventure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Aventure");
                });

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Paragraphe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("EstInitial");

                    b.Property<int>("Numero");

                    b.Property<string>("Titre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Paragraphe");
                });

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParagrapheId");

                    b.Property<string>("Titre");

                    b.HasKey("Id");

                    b.HasIndex("ParagrapheId")
                        .IsUnique();

                    b.ToTable("Question");
                });

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Reponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("ParagrapheId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("ParagrapheId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Proposition");
                });

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Question", b =>
                {
                    b.HasOne("jeudontonestleheros.Core.Data.Models.Paragraphe")
                        .WithOne("MaQuestion")
                        .HasForeignKey("jeudontonestleheros.Core.Data.Models.Question", "ParagrapheId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("jeudontonestleheros.Core.Data.Models.Reponse", b =>
                {
                    b.HasOne("jeudontonestleheros.Core.Data.Models.Paragraphe")
                        .WithMany("Reponses")
                        .HasForeignKey("ParagrapheId");

                    b.HasOne("jeudontonestleheros.Core.Data.Models.Question")
                        .WithMany("MesReponses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
