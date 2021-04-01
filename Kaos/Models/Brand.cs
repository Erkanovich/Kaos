using System.Collections.Generic;

namespace Kaos.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Beer> Beers { get; set; }
    }
}
