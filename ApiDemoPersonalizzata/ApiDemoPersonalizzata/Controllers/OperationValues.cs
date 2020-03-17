using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemoPersonalizzata.Controllers
{
    [Route("api/[controller]/[action]/[action]")]
    public class OperationValues : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public double ConvertitorePiediAMetri(int piedi)
        {
            
            return piedi/3.281;
            
        }
        // GET: api/<controller>
        [HttpGet]
        public double ConvertitoreMetriAPiedi(int metri)
        {

            return metri * 3.281;

        }
        [HttpGet]
        public double GetPercentuale(double percentuale, double numero)
        {
            
            return (percentuale/100)*numero;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
