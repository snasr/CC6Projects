using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cars.Database.Models
{
    public class TrucksDB :DbContext
    {
        public TrucksDB() : base("name=TrucksDB")
        {
        }

        public DbSet<Truck> Trucks { get; set; }
    }
}
