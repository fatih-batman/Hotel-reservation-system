using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class guest
    {
        

        [Key]
        public int id { get; set; }

        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string first_name { get; set; }

        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string last_name { get; set; }

        public DateTime member_since { get; set; }
        public object P1 { get; }
        public object P2 { get; }
        public object P3 { get; }



        public guest(DateTime p3)
        {
            member_since = p3;
        }

        public guest(int id, DateTime p3)
        {
            this.id = id;
            member_since = p3;
        }

        public guest()
        {
        }
    }
}
