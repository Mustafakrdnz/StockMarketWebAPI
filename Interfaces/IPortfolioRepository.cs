using StockMarketWebAPI.Models;

namespace StockMarketWebAPI.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);
    }
}
