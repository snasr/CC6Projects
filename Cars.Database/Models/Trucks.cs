using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Database.Models
{
    public class Truck
    {
        public virtual int Id { get; set; }
        public virtual int Weight { get; set; }
        public virtual int Cylinders { get; set; }
    }
}
