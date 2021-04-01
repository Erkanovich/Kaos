using Kaos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add beers to your collection!");
            Console.WriteLine();
            Console.WriteLine("Press any key to go to menu");
            Console.ReadKey();
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("1: Add beer");
            Console.WriteLine("2: Add beer brand");
            Console.WriteLine("3: Show all beers");
            Console.WriteLine("4: Show all brands");
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AddBeer();
                    break;
                case "2":
                    AddBeerBrand();
                    break;
                case "3":
                    ShowAllBeers();
                    break;
                case "4":
                    ShowAllBrands();
                    break;
                default:
                    break;
            }
        }

        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
            MainMenu();
        }

        private static void AddBeer()
        {
            //skapa en ölsort
            var beer = new Beer();
            //fylla på med info
            Console.Clear();

            //välj brand
            List<Brand> brands;
            using (var dbContext = new BeerDbContext())
            {
                brands = dbContext.Brands.ToList();
                foreach (var brand in brands)
                {
                    Console.WriteLine($"{brand.Id}: {brand.Name}");
                }
                Console.WriteLine("Enter beer brand Id:");
                var brandId = int.Parse(Console.ReadLine());
                beer.Brand = brands.Find(x => x.Id == brandId);

                //sätt namn
                Console.WriteLine("Enter beer name:");
                beer.Name = Console.ReadLine();

                //spara till databas

                dbContext.Beers.Add(beer);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"Brand {beer.Name} added successfully");

            ReturnToMainMenu();
        }

        private static void AddBeerBrand()
        {
            //skapa ett ölmärke
            var brand = new Brand();
            //fylla på med info
            Console.Clear();
            Console.WriteLine("Enter brand name:");
            brand.Name = Console.ReadLine();
            //spara till databas
            using (var dbContext = new BeerDbContext())
            {
                dbContext.Brands.Add(brand);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"Brand {brand.Name} added successfully");

            ReturnToMainMenu();
        }

        private static void ShowAllBeers()
        {
            //deklarera en lista med öl
            List<Beer> beers;
            // använd databasen inom dessa klamrar
            using (var dbContext = new BeerDbContext())
            {
                //hämta öl från databas och lägg till i lista
                beers = dbContext.Beers.ToList();
            }
            // skriv ut alla öl.
            Console.Clear();
            foreach (var beer in beers)
            {
                Console.WriteLine(beer.Name);
            }
            ReturnToMainMenu();
        }

        private static void ShowAllBrands()
        {
            //deklarera en lista med märken
            List<Brand> brands;
            // använd databasen inom dessa klamrar
            using (var dbContext = new BeerDbContext())
            {
                //hämta märken från databas och lägg till i lista
                brands = dbContext.Brands.ToList();
            }
            // skriv ut alla märken.
            Console.Clear();
            foreach (var brand in brands)
            {
                Console.WriteLine(brand.Name);
            }
            ReturnToMainMenu();
        }
    }
}
