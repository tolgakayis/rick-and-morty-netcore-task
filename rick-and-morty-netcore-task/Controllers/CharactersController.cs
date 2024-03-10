using Business.Abstracts;
using Business.Dtos.Character.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rick_and_morty_netcore_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        ICharacterService _characterService;
        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _characterService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync([FromBody] CreateCharacterRequest createCharacterRequest)
        {
            var result = await _characterService.AddAsync(createCharacterRequest);
            return Ok(result);
        }
    }
}
