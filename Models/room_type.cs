using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class room_type
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public String description { get; set; }

        public int max_capasity { get; set; }
    }
}
