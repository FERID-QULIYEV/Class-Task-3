using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Vehicle
{
    class Car
    {
        int _doorCount;
        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value > 1&&value<=7)
                {
                    value = _doorCount;
                }
            }
        }
    }
}
