using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Vehicle
{
    interface IEngine
    {
        public int OilCapality { get; set; }
        double CurrentOil { get; set; }
        string FuelType { get; set; }
        internal abstract double RemainOil()
        {
            return OilCapality - CurrentOil;
        }

    }
}
