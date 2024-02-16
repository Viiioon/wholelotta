public interface IPlayerService
{
    Task<IEnumerable<Player>> GetAllPlayersAsync();
    Task<Player> CreatePlayerAsync(PlayerDto playerDto);
    Task<Player> GetPlayerByIdAsync(string id);
}
