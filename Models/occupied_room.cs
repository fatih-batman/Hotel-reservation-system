using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class occupied_room
    {
        [Key]
        public int id { get; set; }

        public DateTime check_in { get; set; }

        public DateTime check_out { get; set; }

        public room room_id { get; set; }

        public reservation reservation_id { get; set; }
        


    }
}
