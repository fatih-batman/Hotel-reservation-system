using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class reservation
    {
        [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime date_in { get; set; }

        public DateTime date_out { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string made_by { get; set; }

        public guest guest_id { get; set; }

    }
}
