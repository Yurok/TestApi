using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Repository;
using TestApi.Repository.Models;

namespace TestApi.Controllers
{
    public class PartsController : ApiController
    {
        private APartsRepository partsRepository;

        public PartsController() {
            this.partsRepository = new APartsRepository();
        }

        // GET api/values
        public IEnumerable<APart> Get()
        {
            return this.partsRepository.Get();
        }

        // GET api/values/5
        public APart Get(int id)
        {
            return this.partsRepository.Get(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
