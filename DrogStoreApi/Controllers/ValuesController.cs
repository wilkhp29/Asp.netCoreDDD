using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DrogStoreApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IAppStore _appStore;

        public ValuesController(IAppStore appStore)
        {
            _appStore = appStore;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_appStore.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_appStore.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Stores store)
        {
            _appStore.Save(store);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Stores store)
        {
            _appStore.Update(store);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appStore.Delete(id);
        }
    }
}
