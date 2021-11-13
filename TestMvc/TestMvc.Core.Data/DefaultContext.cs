using EnergySport.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMvc.Core.Data.Models;

namespace TestMvc.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Booklet> Booklets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Sub> Subs { get; set; }
        public DbSet<SubBooklet> SubBooklets { get; set; }
        public DbSet<Subscription> SubSubscriptions { get; set; }

        public DbSet<Aventure> Aventures { get; set; }
        public DbSet<Paragraphe> Paragraphes { get; set;}
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reponse> Reponses { get; set; }
        public DbSet<Session_Participant_Member> session_Participant_Members { get; set; }
        public DbSet<Session_WaitingList_Member> session_WaitingList_Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultContext"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session_Participant_Member>().HasKey(bc => new { bc.MemberId, bc.SessionId });
            modelBuilder.Entity<Session_Participant_Member>()
                .HasOne(bc => bc.Member)
                .WithMany(b => b.Participants)
                .HasForeignKey(bc => bc.MemberId);
            modelBuilder.Entity<Session_Participant_Member>()
                .HasOne(bc => bc.Session)
                .WithMany(b => b.Participants)
                .HasForeignKey(bc => bc.SessionId);
            modelBuilder.Entity<Session_WaitingList_Member>().HasKey(bc => new { bc.MemberId, bc.SessionId });
            modelBuilder.Entity<Session_WaitingList_Member>()
                .HasOne(bc => bc.Member)
                .WithMany(b => b.WaitingList)
                .HasForeignKey(bc => bc.MemberId);
            modelBuilder.Entity<Session_WaitingList_Member>()
                .HasOne(bc => bc.Session)
                .WithMany(b => b.WaitingList)
                .HasForeignKey(bc => bc.SessionId);
        }


    }
}
