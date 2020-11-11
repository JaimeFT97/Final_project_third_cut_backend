using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Domain;
using Backend.Infrastructure;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private RC_DBContext builder;

        public ArtistController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> Get()
        {
            return await builder.Artist.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Artist>> Create([FromBody] Artist artist)
        {
            builder.Artist.Add(artist);
            await builder.SaveChangesAsync();

            return artist;
        }
        /*
        public async Task<List<Country>> GetCountry()
        {
            return await builder.Country.Select(c => new Country()
            {
                Id = c.Id,
                Country_name = c.Country_name
            }).ToListAsync();
        }*/
    }
}