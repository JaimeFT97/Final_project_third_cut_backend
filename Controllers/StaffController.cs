﻿using System;
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
    public class StaffController : ControllerBase
    {
        private RC_DBContext builder;

        public StaffController(RC_DBContext rC_DBContext)
        {
            builder = rC_DBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> Get()
        {
            return await builder.Staff.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Staff>> Create([FromBody] Staff staff)
        {
            builder.Staff.Add(staff);
            await builder.SaveChangesAsync();

            return staff;
        }
    }
}