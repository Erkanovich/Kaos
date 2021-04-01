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
            Console.WriteLine("3: Show all beers");
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

        private void AddBeer()
        {
            throw new NotImplementedException();
        }

        private void AddBeerBrand()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBeers()
        {
            throw new NotImplementedException();
        }

        private void ShowAllBrands()
        {
            throw new NotImplementedException();
        }
    }
}
