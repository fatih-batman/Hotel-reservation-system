using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class reservationX
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

        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string guest_first_name { get; set; }

        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string guest_last_name { get; set; }

        public int room_number { get; set; }

        public DateTime check_in { get; set; }

        public DateTime check_out { get; set; }

    }
}
