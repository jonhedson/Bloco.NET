using DemoEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.tektutorialshub.com/entity-framework-core-tutorial/
            Console.WriteLine("Hello World!");
            insertProduct();
            readProduct();
            updateProduct();
            readProduct();
            deleteProduct();
            readProduct();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();



        }

        static void insertProduct()
        {
            using (var db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Pen Drive";
                db.Add(product);

                db.SaveChanges();
            }
            return;
        }

        static void readProduct()
        {
            using (var db = new EFContext())
            {
                List<Product> products = db.Products.ToList();
                foreach(Product p in products)
                {
                    Console.WriteLine("{0} {1}", p.Id, p.Name);
                }
            }
        }

        static void updateProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(2);
                product.Name = "Better PenDrive";
                db.SaveChanges();
            }
            return;
        }

        static void deleteProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(2);
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return;
        }
    }
}
