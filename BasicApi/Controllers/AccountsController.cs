using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            // Example static list; replace with your data source as needed
            var accounts = new List<Account>
            {
                new Account { Id = 1, Type = "Checking", Balance = 1500.50m },
                new Account { Id = 2, Type = "Savings", Balance = 3200.00m },
                new Account { Id = 3, Type = "Investment", Balance = 10000.75m }
            };

            return Ok(accounts);
        }
    }
}