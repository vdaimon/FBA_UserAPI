using FBA_UserAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FBA_UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BalanceController : ControllerBase
    {
        DataBaseContext db;
        public BalanceController(DataBaseContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<Balance>> Get()
        {
            Balance balance = await db.Balances.OrderBy(x=>x.DateTime).LastAsync();

            if (balance == null)
                return NotFound();

            return Ok(balance);
        }

        [Route ("balanceList")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Balance>>> GetBalanceList()
        {
            var balances = await db.Balances.ToListAsync();

            if (balances == null)
                return NotFound();

            return Ok(balances);
        }
        
        [HttpPost]
        public async Task<ActionResult<Balance>> Post(Balance balance)
        {
            if (balance == null)
                return BadRequest();

            db.Balances.Add(balance);
            await db.SaveChangesAsync();
            
            return Ok(balance);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBalance(int id)
        {
            Balance? balance = db.Balances.FirstOrDefault(x => x.Id == id);
            
            if (balance == null)
                return NotFound();

            db.Balances.Remove(balance);
            await db.SaveChangesAsync();

            return Ok(balance);
        }

    }
}
