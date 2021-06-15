using Sandbox.WebAPI.Generator;
using System.Collections.Generic;
using System.Web.Http;

namespace Sandbox.WebAPI.Controllers
{
    [RoutePrefix("values")]
    public class ValuesController : ApiController
    {
        private const int MAX_ITEMS_QUANTITY = 10;

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("random/positive")]
        public List<int> GetRandomPositive(int? quantity=MAX_ITEMS_QUANTITY)
        {

                if (quantity.HasValue && quantity.Value>MAX_ITEMS_QUANTITY)
                {
                quantity=MAX_ITEMS_QUANTITY;
                }

            var generator = new RandomPositiveNumberGenerator();
            return generator.Generate(quantity.Value);
        }
    }
}
