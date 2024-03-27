using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyEx5_start
{
    class Garage<T>
    {
        public List<Vehicle> VehicleList { get; set; }
        public List<Vehicle> MyList { get; set; }

        public Garage()
        {
            VehicleList = new List<Vehicle>();
            MyList = new List<Vehicle>();
        }

    }
    
}