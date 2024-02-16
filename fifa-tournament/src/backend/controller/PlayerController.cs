using Microsoft.AspNetCore.Mvc;
using FifaTournament.Backend.Models; // Update this with the actual namespace of your Player model

[Route("api/[controller]")]
[ApiController]
public class PlayersController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayersController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    // GET: api/Players
    [HttpGet]
    public async Task<IActionResult> GetPlayers()
    {
        var players = await _playerService.GetAllPlayersAsync();
        return Ok(players);
    }

    // POST: api/Players
    [HttpPost]
    public async Task<IActionResult> CreatePlayer([FromBody] PlayerDto playerDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdPlayer = await _playerService.CreatePlayerAsync(playerDto);

        return CreatedAtAction(nameof(GetPlayer), new { id = createdPlayer.Id }, createdPlayer);
    }

    // GET: api/Players/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPlayer(string id)
    {
        var player = await _playerService.GetPlayerByIdAsync(id);

        if (player == null)
        {
            return NotFound();
        }

        return Ok(player);
    }

    // Additional methods to update and delete players can be added here.
}
