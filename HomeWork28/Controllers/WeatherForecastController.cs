using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork28.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HomeWork28.Controllers
{
    [ApiController]
    [Route("api")]
    public class FrazesController : ControllerBase
    {
        DCon db;

        public FrazesController(DCon context)
        {
            db = context;

        }

        // GET: api/<controller>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Frazi>>> Get()
        {
            return await db.Frazes.ToListAsync();
        }

        // GET api/Frazi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Frazi>> Get(int id)
        {
            Frazi Frazi = await db.Frazes.FirstOrDefaultAsync(x => x.Id == id);
            if (Frazi == null)
                return NotFound();
            return new ObjectResult(Frazi);
        }

        // POST api/Frazi
        [HttpPost]
        public ActionResult Post(Frazi Frazi)
        {
            if (Frazi == null)
            {
                return BadRequest();
            }
            db.Frazes.Add(Frazi);
            db.SaveChanges();
            return Ok();
        }

        // PUT api/Frazi/
        [HttpPut("{id}")]
        public ActionResult Put(Frazi Frazi, int id)
        {
            if (Frazi == null)
            {
                return BadRequest();
            }
            Frazi.Id = id;
            if (!db.Frazes.Any(x => x.Id == Frazi.Id))
            {
                return NotFound();
            }
            db.Update(Frazi);
            db.SaveChanges();
            return Ok();
        }

        // DELETE api/Frazi/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Frazi Frazi = db.Frazes.FirstOrDefault(x => x.Id == id);
            if (Frazi == null)
            {
                return NotFound();
            }
            db.Frazes.Remove(Frazi);
            db.SaveChanges();
            return Ok(Frazi);
        }
    }
}
