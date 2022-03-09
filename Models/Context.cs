using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("server=DESKTOP-NBF1RV7; database = HotelDatabase; integrated security=true");
        }

        public DbSet<room> room{ get; set; }
        public DbSet<room_type> room_type { get; set; }
        public DbSet<reserved_room> reserved_room { get; set; }

        public DbSet<reservation> reservation { get; set; }
        public DbSet<guest> guest { get; set; }

        public DbSet<hosted_at> hosted_at{ get; set; }
        public DbSet<occupied_room> occupied_room { get; set; }

        public DbSet<account> accountx { get; set; }

        public DbSet<reservationX> reservations { get; set; }

    }
}
