using Carteles.Backend.Data;
using Carteles.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carteles.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<CountriesController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        // GET api/<CountriesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }


        // POST api/<CountriesController>
        [HttpPost]
        public async Task<IActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }


        // PUT api/<CountriesController>/5
        [HttpPut]
        public async Task<IActionResult> PutAsync(Country country)
        {
            _context.Update(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }


        // DELETE api/<CountriesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
