using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using SpaceXStore.Helper;
using SpaceXStore.Models;

namespace SpaceXStore.Controllers
{
    public class ProductController : Controller
    {
        ServiceApi _api = new ServiceApi();

        public async Task<IActionResult> Index(string SortBy, string direction)
        {
           var sortDirection = direction == "DESC" ? SortDirection.DESC : SortDirection.ASC;

            Store store = new Store();
            List <Product> products = new List<Product>();

            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Store");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;

                store = JsonConvert.DeserializeObject<Store>(result);


                switch (SortBy)
                {
                    case "Title":
                        if (sortDirection == SortDirection.DESC)
                        {
                            products = store.Products.OrderByDescending(a => a.Title).ToList();
                        }
                        else
                        {
                            products = store.Products.OrderBy(a => a.Title).ToList();
                        }
                        break;

                    case "Description":
                        if (sortDirection == SortDirection.DESC)
                        {
                            products = store.Products.OrderByDescending(a => a.Description).ToList();
                        }
                        else
                        {
                            products = store.Products.OrderBy(a => a.Description).ToList();
                        }
                        break;

                    case "Price":
                        if (sortDirection == SortDirection.DESC)
                        {
                            products = store.Products.OrderByDescending(a => a.Price).ToList();
                        }
                        else
                        {
                            products = store.Products.OrderBy(a => a.Price).ToList();
                        }
                        break;

                    case "Popular":
                        if (sortDirection == SortDirection.DESC)
                        {
                            products = store.Products.OrderByDescending(a => a.SortOrder).ToList();
                        }
                        else
                        {
                            products = store.Products.OrderBy(a => a.SortOrder).ToList();
                        }
                        break;

                    case "Id":
                    default:
                        if (sortDirection == SortDirection.DESC)
                        {
                            products = store.Products.OrderByDescending(a => a.Id).ToList();
                        }
                        else
                        {
                            products = store.Products.OrderBy(a => a.Id).ToList();
                        }
                        break;
                }

                store.Products = products;
                store.SortedBy = SortBy;
                store.Direction = sortDirection;
            }

            return View(store);
        }
 
    }
}