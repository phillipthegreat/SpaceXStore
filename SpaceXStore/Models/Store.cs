using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceXStore.Models
{
    public class Store
    {
        public List<Product> Products { get; set; }

        public string SortedBy { get; set; }
        public SortDirection Direction { get; set; }

    }

    public enum SortDirection
    {
        ASC = 1,
        DESC = 2
    }
}
