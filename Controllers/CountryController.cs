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
    public class CountryController : ControllerBase
    {
        private RC_DBContext builder;

        public CountryController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> Get()
        {
            return await builder.Country.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Country>> Create([FromBody] Country country)
        {
          builder.Country.Add(country);
          await builder.SaveChangesAsync();

            return country;
        }
    }
}