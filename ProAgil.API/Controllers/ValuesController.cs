using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Model;
using ProAgil.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProAgil.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }

        public ValuesController(DataContext context)
        {
            _context = context;
        }


        //GET api/values
        [HttpGet]

        public async Task<IActionResult> Get () //chamada assíncrona para criar várias treads no BD para cada requisição e não travar o recurso.
        {
            try
            {
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou");
            }
            
        }

        //GET api/values/5
        [HttpGet("{id}")]

        public  async Task<IActionResult> Get(int id)
        {
            
            try
            {
                var results = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou");
            }
        }

        //POST api/values
        [HttpPost]

        public void Post([FromBody] string value)
        {            
        }

        //PUT api/values/5
        [HttpPut("{id}")]

        public void Put(int id,[FromBody] string value)
        {
        }

        //DELETE api/values/5
        [HttpDelete("{id}")]

        public void Delete(int id)
        {

        }

    }
}