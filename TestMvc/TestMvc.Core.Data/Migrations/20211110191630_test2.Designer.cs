﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestMvc.Core.Data;

namespace TestMvc.Core.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20211110191630_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnergySport.Data.Models.Activity", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndRegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndUnregisterDate")
                        .HasColumnType("time");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("MaxRegisterNumberByClient")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartRegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Code");

                    b.HasIndex("CategoryId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Booklet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("SessionQty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Booklets");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookletId")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookletId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coachs");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CoachId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstSessionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastSessionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxParticipantsNumber")
                        .HasColumnType("int");

                    b.Property<int>("MinParticipantsNumber")
                        .HasColumnType("int");

                    b.Property<string>("PrivateCommentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicCommentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WaitingListMaxSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityCode");

                    b.HasIndex("CoachId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LandLinePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MedicalCertificateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MedicalCertificateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.Property<int?>("SessionId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.HasIndex("SessionId1");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("MaxParticipantsNumber")
                        .HasColumnType("int");

                    b.Property<int>("MinParticipantsNumber")
                        .HasColumnType("int");

                    b.Property<string>("PrivateCommentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicCommentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SessionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WaitingListMaxSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Sub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("Subs");
                });

            modelBuilder.Entity("EnergySport.Data.Models.SubBooklet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookletId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<int?>("SessionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookletId");

                    b.HasIndex("MemberId");

                    b.ToTable("SubBooklets");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("SubSubscriptions");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Aventure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aventure");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Paragraphe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paragraphe");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParagrapheId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParagrapheId")
                        .IsUnique();

                    b.ToTable("Question");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Reponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParagrapheId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Reponse");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Activity", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Category", null)
                        .WithMany("Activities")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Category", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Booklet", null)
                        .WithMany("Categories")
                        .HasForeignKey("BookletId");

                    b.HasOne("EnergySport.Data.Models.Subscription", null)
                        .WithMany("Categories")
                        .HasForeignKey("SubscriptionId");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Course", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityCode");

                    b.HasOne("EnergySport.Data.Models.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachId");

                    b.Navigation("Activity");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Member", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Session", null)
                        .WithMany("Participants")
                        .HasForeignKey("SessionId");

                    b.HasOne("EnergySport.Data.Models.Session", null)
                        .WithMany("WaitingList")
                        .HasForeignKey("SessionId1");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Session", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Course", null)
                        .WithMany("Sessions")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Sub", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Member", "Member")
                        .WithMany("Subs")
                        .HasForeignKey("MemberId");

                    b.HasOne("EnergySport.Data.Models.Subscription", "Subscription")
                        .WithMany()
                        .HasForeignKey("SubscriptionId");

                    b.Navigation("Member");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("EnergySport.Data.Models.SubBooklet", b =>
                {
                    b.HasOne("EnergySport.Data.Models.Booklet", "Booklet")
                        .WithMany()
                        .HasForeignKey("BookletId");

                    b.HasOne("EnergySport.Data.Models.Member", "Member")
                        .WithMany("SubBooklets")
                        .HasForeignKey("MemberId");

                    b.Navigation("Booklet");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Question", b =>
                {
                    b.HasOne("TestMvc.Core.Data.Models.Paragraphe", null)
                        .WithOne("QuestionId")
                        .HasForeignKey("TestMvc.Core.Data.Models.Question", "ParagrapheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Reponse", b =>
                {
                    b.HasOne("TestMvc.Core.Data.Models.Question", null)
                        .WithMany("Reponses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnergySport.Data.Models.Booklet", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Category", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Course", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Member", b =>
                {
                    b.Navigation("SubBooklets");

                    b.Navigation("Subs");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Session", b =>
                {
                    b.Navigation("Participants");

                    b.Navigation("WaitingList");
                });

            modelBuilder.Entity("EnergySport.Data.Models.Subscription", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Paragraphe", b =>
                {
                    b.Navigation("QuestionId");
                });

            modelBuilder.Entity("TestMvc.Core.Data.Models.Question", b =>
                {
                    b.Navigation("Reponses");
                });
#pragma warning restore 612, 618
        }
    }
}