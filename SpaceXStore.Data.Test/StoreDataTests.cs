using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceXStore.Data.Data;

namespace SpaceXStore.Data.Test
{
    [TestClass]
    public class StoreDataTests
    {
        [TestMethod]
        public void GetProducts()
        {
            StoreData sd = new StoreData();

            Assert.IsNotNull(sd.storeData);
            Assert.AreEqual(12, sd.storeData.Products.Count);
            Assert.IsNotNull(sd.storeData.Products[0].SortOrder);
            Assert.IsTrue(sd.storeData.Products[0].Specs.Count > 0);
        }
    }
}
