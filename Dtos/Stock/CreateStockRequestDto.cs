﻿using StockMarketWebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarketWebAPI.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public string? MarketCap { get; set; }
    }
}
