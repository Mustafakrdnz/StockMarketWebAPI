using StockMarketWebAPI.Models;

namespace StockMarketWebAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
