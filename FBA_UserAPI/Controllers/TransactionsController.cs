using Microsoft.AspNetCore.Mvc;
using FBA_UserAPI.Models;
using RestClient.Net;

namespace FBA_UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Post(Transaction transaction)
        {
            if (transaction == null)
                return BadRequest();

            using var client = new Client("https://localhost:7217");

            await client.PostAsync<Transaction, Transaction>(transaction, "api/transaction");

            return Ok();
        }
    }
}
