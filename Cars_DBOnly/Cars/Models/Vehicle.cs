using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars.Models
{
    public class Vehicle
    {
        public virtual int Id { get; set; }
        public virtual int Year { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual int Qty { get; set; }
        public virtual int VehicleTypeId { get; set; }

        //   public virtual Genre Genre { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}