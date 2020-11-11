using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend.Domain
{
    public class Country
    {
        public int Id { get; set; }
        public string Country_name { get; set; }
    }
}
