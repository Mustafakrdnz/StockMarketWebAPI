using StockMarketWebAPI.Models;

namespace StockMarketWebAPI.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
    }
}
