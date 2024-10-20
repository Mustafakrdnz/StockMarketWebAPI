using Microsoft.EntityFrameworkCore;
using StockMarketWebAPI.Data;
using StockMarketWebAPI.Interfaces;
using StockMarketWebAPI.Models;

namespace StockMarketWebAPI.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly ApplicationDBContext _context;

        public PortfolioRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Portfolio> CreateAsync(Portfolio portfolio)
        {
            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
            return portfolio;
        }

        public async Task<List<Stock>> GetUserPortfolio(AppUser user)
        {
            return await _context.Portfolios.Where(p => p.AppUserId == user.Id)
                .Select(Stock => new Stock
                {
                    Id = Stock.StockId,
                    Symbol = Stock.Stock.Symbol,
                    CompanyName = Stock.Stock.CompanyName,
                    Purchase = Stock.Stock.Purchase,
                    LastDiv = Stock.Stock.LastDiv,
                    Industry = Stock.Stock.Industry,
                    MarketCap = Stock.Stock.MarketCap
                }).ToListAsync();
        }
    }
}
