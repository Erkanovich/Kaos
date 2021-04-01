using System;

namespace Kaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add beers to your collection!");
            Console.WriteLine();
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

        private static void AddBeer()
        {
            throw new NotImplementedException();
        }

        private static void AddBeerBrand()
        {
            throw new NotImplementedException();
        }

        private static void ShowAllBeers()
        {
            throw new NotImplementedException();
        }

        private static void ShowAllBrands()
        {
            throw new NotImplementedException();
        }
    }
}
