using BankProject.Data;
using BankProject.BankProjectmodel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankInfoController : ControllerBase
    {
        private readonly BankContext _context;

        public BankInfoController(BankContext context)
        {
            _context = context;
        }

        // GET: api/BankInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankInfo>>> GetBankInfos()
        {
            return await _context.BankInfo.ToListAsync();
        }

        // GET: api/BankInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankInfo>> GetBankInfo(int id)
        {
            var bankInfo = await _context.BankInfo.FindAsync(id);

            if (bankInfo == null)
            {
                return NotFound();
            }

            return bankInfo;
        }
    }
}
