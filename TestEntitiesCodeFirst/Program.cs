using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace TestEntitiesCodeFirst
{
    class Program
    {
        static void Main2(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultContext");
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionString);
            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                var query = from droide in context.Droides
                            select droide;
                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
