using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Album
    {
        
        public int Id { get; set; }

        public string Album_name { get; set; }
        public string Album_cover { get; set; }
        public int Song_quantity { get; set; }
        public string Duration { get; set; }
        public string Link_album { get; set; }
        public Artist Artist { get; set; }
        public int? Artist_id { get; set; }
    }
}
