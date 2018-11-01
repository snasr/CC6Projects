using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars.ViewModels
{
    public class VehicleVM
    {
        public virtual int Year { get; set; }
        public virtual string Make { get; set; }
        public virtual string Model { get; set; }
        public virtual double Price { get; set; }
        public virtual double Tax { get; set; }
        public virtual double TotalCost { get; set; }
    }
}