using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Vehicle
{
    class Bicycle
    {
        string _pedalKind;
        public string PedalKind 
        {
            get { return _pedalKind; }
            set
            {
                if (value.Length>0)
                {
                    value = _pedalKind;
                }
            }
        }
    }
}
