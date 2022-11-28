using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Vehicle
{
    abstract class Vehicle
    {
        double _driveTime;
        double _drivePath;
        public double DriveTime
        {
            get { return _driveTime; }
            set
            {
                if (value > 0)
                {
                    value = _driveTime;
                } 
            }
        }
        public double DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value > 0)
                {
                    value = _drivePath;
                }
            }
        }
        public double AvarageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
            return DrivePath / DriveTime;
        }
    }
}
