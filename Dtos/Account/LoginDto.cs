using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StockMarketWebAPI.Dtos.Account
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
