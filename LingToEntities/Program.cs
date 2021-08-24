using LingToEntities.Models;
using Microsoft.EntityFrameworkCore;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LingToEntities
{
    class Program
    {
        static Stopwatch Chrono = new Stopwatch();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            Method20();
        }

        static void Method1()
        {
            List<Customer> customers = new List<Customer>();
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                customers = dbContext.Customers.Where(c => c.CompanyName.StartsWith("s")).ToList();
            }
        }
        static void Method2()
        {
            Customer customer = new Customer();
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                customer = dbContext.Customers.Where(c => c.CompanyName.StartsWith("s")).FirstOrDefault();
            }
        }
        static void Method3()
        {
            Customer customer = new Customer();
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                customer = dbContext.Customers.Where(c => c.CompanyName.StartsWith("s")).OrderBy(c => c.CompanyName).FirstOrDefault();
            }
        }
        static void Method15()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test2 = dbContext.Categories.Include(cat => cat.Products).Skip(4).Take(5);

                // var test2 = dbContext.Categories.GroupJoin(dbContext.Products, c => c.CategoryId, p => p.CategoryId, (categories, produits) => new { categories, produits });
                foreach (var categorie in test2)
                {
                    Console.WriteLine("Catégorie{0} {1}", categorie.CategoryId, categorie.CategoryName);
                    foreach (var item in categorie.Products)
                    {
                        Console.WriteLine("Produits {0} {1}", item.ProductId, item.ProductName);
                    }

                }
            }
        }
        static void Method4()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test = dbContext.Employees.Include(ord => ord.Orders).Where(dbContext => dbContext.Country == "USA");
                Console.WriteLine(test.ToQueryString());
                foreach (var employee in test)
                {
                    Console.WriteLine("Employe : {0} {1} {2}", employee.FirstName, employee.LastName, employee.Orders.Count);
                }
            }
        }
        static void Method5()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                //var prod = dbContext.Products.Where(p => p.Discontinued == true);
                var test = dbContext.Categories.Where(p => p.Products.Any(prod => prod.Discontinued == true)).ToList();

                //Console.WriteLine(test.ToQueryString());
            }
        }
        static void Method6()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test = dbContext.Customers.Include(o => o.Orders).ToList();
                foreach (var item in test)
                {
                    Console.WriteLine("{0} {1}", item.ContactName, item.Orders.Count);
                }
                var test2 = dbContext.Customers.Include(o => o.Orders).Where(ord => ord.Orders.Count() > 0).ToList();
                var test3 = dbContext.Customers.Where(ord => ord.Orders.Count() > 0).ToList();
            }
        }
        static void Method7()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test2 = dbContext.Customers.Where(ord => ord.Orders.Count() == 0).ToList();
            }

        }
        static void Method8()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                //var test2 = dbContext.Customers.Where(ord => ord.Orders.Max().OrderDate.Value.Year <= 2008);
                var test2 = dbContext.Customers.Where(ord => ord.Orders.All(ord => ord.OrderDate.Value.Year <= 2010));
            }
        }
        static void Method9()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test = dbContext.Categories.Where(p => p.Products.All(prod => prod.Discontinued == false)).ToList();
            }
        }
        static void Method10()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                //     var test = dbContext.Customers.Where(c => c.Country == "France").Include(ord => ord.Orders.Sum).ThenInclude(odd => odd.OrderDetails);
                //  var test = dbContext.Customers.Where(c => c.Country == "France").Sum(o => o.Orders.Sum(od => od.OrderDetails.Sum(ol => ol.Quantity * ol.UnitPrice)));
                var cde = dbContext.Orders.Where(o => o.Customer.Country == "France").Select(CaC => new { Client = CaC.Customer, Ca = CaC.OrderDetails.Sum(ol => (ol.Quantity * ol.UnitPrice) - ((ol.Quantity * ol.UnitPrice) * (decimal)ol.Discount)) }).ToLookup(x => x.Client);
                var ccc = dbContext.Orders.Where(o => o.Customer.Country == "France");
                var test = from c in dbContext.Customers
                           where c.Country == "France"
                           join o in dbContext.Orders on c.CustomerId equals o.CustomerId
                           join od in dbContext.OrderDetails on o.OrderId equals od.OrderId
                           select new { Client = c.ContactName, CA = o.OrderDetails.Sum(odd => (odd.UnitPrice * odd.Quantity) - ((odd.Quantity * odd.UnitPrice) * (decimal)odd.Discount)) };
                var test2 = test.ToList().GroupBy(x => x.Client);
                foreach (var item in test2)
                {
                    Console.WriteLine("{0} {1}", item.Key);
                }
            }

        }
        static void Method11()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                //var cde = dbContext.Orders.Where(o => o.Customer.Country == "France").Select(CaC => new { Client = CaC.Customer, Ca = CaC.OrderDetails.Sum(ol => (ol.Quantity * ol.UnitPrice) - ((ol.Quantity * ol.UnitPrice) * (decimal)ol.Discount)) });
                var cde = dbContext.Orders.Select(CaC => new { Client = CaC.Customer, Ca = CaC.OrderDetails.Sum(ol => (ol.Quantity * ol.UnitPrice) - ((ol.Quantity * ol.UnitPrice) * (decimal)ol.Discount)) });
                var cde2 = cde.OrderByDescending(c => c.Ca).First();
            }
        }
        static void Method12()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                Chrono.Restart();
                var test3 = dbContext.Categories.Select(res => new { cat = res.CategoryName, pri = res.Products.Max(u => u.UnitPrice) }).ToList(); ;
                Console.WriteLine($"Temps 12 F : {Chrono.ElapsedMilliseconds}");
                foreach (var item in test3)
                {
                    Console.WriteLine("{0} {1}", item.cat, item.pri);
                }
            }
        }
        static void Method20()
        {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities())
            {
                var test = dbContext.Products.Where(x => x.CategoryId == 8);
                var test2 = dbContext.Orders.Where(x => x.OrderDate > DateTime.Now.AddYears(-12)).Select(res => new { res.Customer.ContactName });
                var test3 = dbContext.Suppliers.Where(x => x.Products.Count > 3);
                var test4 = dbContext.Employees.Select(x => new { Supp = x.ReportsToNavigation.FirstName, Employee = x.FirstName }).ToList().GroupBy(x => x.Supp);
                var test5 = dbContext.Shippers.Select(x => new { Ship = x.CompanyName, NbOrder = x.Orders.Count });
                var test6 = dbContext.Orders.Average(x => EF.Functions.DateDiffDay(x.OrderDate, x.ShippedDate));

            }
        }
    }
}
