using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceXStore.Data.Data;
using SpaceXStore.Data.Model;

namespace SpaceXStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private StoreData _store;

        public StoreController()
        {
            _store = new StoreData();
        }
        public ActionResult Index()
        {
            return new JsonResult(_store.storeData);
        }

        [HttpGet]
        public Store GetStore()
        {
            return _store.storeData;
        }
    }
}