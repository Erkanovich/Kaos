using System;

namespace Kaos.Models
{
    public class Beer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? AlcoholPercentage { get; set; }
        public Brand Brand { get; set; }
    }
}
