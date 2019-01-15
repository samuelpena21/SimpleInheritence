using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence.Interface
{
    interface Vehicle
    {
        string Name { get; set; }
        int Wheels { get; set; }
        void TurnOn();
        void TurnOff();
        void GoForward();
        void Reverse();
    }
}
