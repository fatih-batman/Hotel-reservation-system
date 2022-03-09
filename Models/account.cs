using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class account
    {
        [Key]
        public int admin_ID { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string user_name { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string password { get; set; }
    }
}
