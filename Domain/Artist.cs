using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Artist
    {
        public  int Id { get; set; }
        public string Artistic_name { get; set; }
        public string Real_name { get; set; }
        public Country Country { get; set; }
        public int? Country_id { get; set; }
        public float Average_salary { get; set; }
        public string Occupation { get; set; }

        
    }
}
