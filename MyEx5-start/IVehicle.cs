using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyEx5_start
{
    internal interface IVehicle
    {
       
        void Park();
        string Display();
        int Count();
        void Leave();
        void Find();
        void SearchQuery();

        
    }
}
