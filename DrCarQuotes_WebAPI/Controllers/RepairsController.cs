using Microsoft.AspNetCore.Mvc;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RepairsController : ControllerBase
{
    // GET: api/<RepairsController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<RepairsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<RepairsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {

    }

    // PUT api/<RepairsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<RepairsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
