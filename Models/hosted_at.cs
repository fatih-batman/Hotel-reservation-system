using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class hosted_at
    {
        [Key]
        public int id { get; set; }
        
        public guest guest_id { get; set; }

        public occupied_room occupied_room_id { get; set; }


    }
}
