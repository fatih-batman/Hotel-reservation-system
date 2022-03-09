using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class room
    {

        [Key]
        public int id { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string number { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string name { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string status { get; set; }

        public Boolean smoke { get; set; }

        public room_type room_type_id { get; set; }



    }
}
