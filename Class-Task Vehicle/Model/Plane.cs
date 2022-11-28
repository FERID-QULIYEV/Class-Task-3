using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Vehicle
{
    class Plane
    {
        double _wingLength;
        public double WingLengt
        {
            get { return _wingLength; }
            set
            {
                if (value > 0)
                {
                    value = _wingLength;
                }
            }
        }
    }
}
