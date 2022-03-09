using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class reserved_room
    {
        [Key]
        public int id { get; set; }

        public int number_of_room { get; set; }

        public room_type room_type_id { get; set; }

        public reservation reservation_id { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string status { get; set; }
    }
}
