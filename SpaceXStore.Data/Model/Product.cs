using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SpaceXStore.Data.Model
{
    [Serializable()]
    public class Product
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Sorting Sorting { get; set; }
        public List<Spec> Specs { get; set; }
        public string Availability { get; set; }

        public int SortOrder
        {
            get
            {
                return Sorting?.Popular ?? 99999;
            }
        }
    }

    [Serializable()]
    public class Sorting
    {
        public int Popular { get; set; }
    }

    [Serializable()]
    public class Spec
    {
        [XmlText]
        public string Value { get; set; }
    }
}
