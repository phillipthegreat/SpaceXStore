using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceXStore.Data.Model
{
    [Serializable()]
    public class Store
    {
        public List<Product> Products { get; set; }
    }
}
