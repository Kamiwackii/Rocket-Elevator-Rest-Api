// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using restapi.Contexts;

// namespace restapi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class BuildingsController : ControllerBase
//     {
//         private readonly RestApiContext context;

//         public BuildingsController(RestApiContext context)
//         {
//             this.context = context;
//         }

//         // GET: api/Buildings
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<Building>>> GetBuildings()
//         {
//             return await this.context.Buildings.ToListAsync();
//         }
//         // GET: api/Buildings/hasIntervention
//         [HttpGet("hasIntervention")]
//         public List<Building> GetBuildingsIntervention()
//         {
//             var buildings = this.context.Buildings.Where(b => HasIntervention(b)).ToList();
//             return buildings;
//         }
//         private bool HasIntervention(Building b)
//         {
//             if (b.batteries.Any(bat => bat.status == "intervention" || bat.columns.Any(c => c.status == "intervention" || c.elevators.Any(e => e.status == "intervention")))) 
//             {
//                 return true;
//             }
//             return false;
//         }
//     }   
// }