using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restapi.Contexts;
using restapi.Payloads;

namespace restapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnsController : ControllerBase
    {
        private readonly RestApiContext context;

        public ColumnsController(RestApiContext context)
        {
            this.context = context;
        }

        // GET: api/Columns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Column>>> GetColumns()
        {
            return await this.context.Columns.ToListAsync();
        }

        // GET: api/Columns/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Column>> GetColumn([FromRoute] long id)
        {
            var myColumn = await this.context.Columns.FindAsync(id);

            if (myColumn == null)
            {
                return NotFound();
            }

            return myColumn;
        }

        // GET: api/Columns/{id}/status
        [HttpGet("{id}/status")]
        public async Task<ActionResult<string>> GetColumnStatus([FromRoute] long id)
        {
            var myColumn = await this.context.Columns.FindAsync(id);

            if (myColumn == null)
            {
                return NotFound();
            }

            return myColumn.status;
        }

        // POST: api/Columns/{id}/status
        [HttpPut("{id}/status")]
        public async Task<ActionResult> UpdateColumnStatus([FromRoute] long id, [FromBody] UpdateStatusPayload payload)
        {
            var myColumn = await this.context.Columns.FindAsync(id);

            if (myColumn == null)
            {
                return NotFound();
            } 
            
            myColumn.status = payload.active ? "active" : "inactive";

            this.context.Columns.Update(myColumn);
            await this.context.SaveChangesAsync();

            return NoContent();
        }
    }
}