using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceXStore.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Sorting Sorting { get; set; }
        public List<Spec> Specs { get; set; }
        public string Availability { get; set; }

        public int SortOrder { get; set; }

        
    }

    public class Sorting
    {
        public int Popular { get; set; }
    }

    public class Spec
    {
        public string Value { get; set; }
    }
}
