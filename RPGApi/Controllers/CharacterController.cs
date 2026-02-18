using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGApi.Data;
using RPGApi.Models;

namespace RPGApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;
        public CharacterController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetAll()
        {
            var characters = await _context.Characters.ToListAsync();
            return Ok(characters);
        }

        [HttpPost]
        public async Task<ActionResult<Character>> Create(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return Ok(character);
        }
    }
}
