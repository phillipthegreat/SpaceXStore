using SpaceXStore.Data.Helper;
using SpaceXStore.Data.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SpaceXStore.Data.Data
{
    public class StoreData
    {
        private Store _storeData;

        public StoreData()
        {
            var sList = Serializer.Deserialize(Path.Combine(Environment.CurrentDirectory, "Files\\List.xml"));
            var sDetail = Serializer.Deserialize(Path.Combine(Environment.CurrentDirectory, "Files\\Detail.xml"));
            _storeData = new Store();
            _storeData.Products = new List<Product>();

            foreach (var prod in sList.Products)
            {
                prod.Specs = sDetail.Products.Where(p => p.Id == prod.Id).Select(s => s.Specs).FirstOrDefault();
                prod.Availability = sDetail.Products.Where(p => p.Id == prod.Id).Select(s => s.Availability).FirstOrDefault();
                _storeData.Products.Add(prod);
            }
        }

        public Store storeData { get { return _storeData; } }

    }
}
