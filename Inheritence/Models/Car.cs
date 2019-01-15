using Inheritence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence.Models
{
    class Car : Vehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set ; }

        public Car()
        {
            Wheels = 4;
        }
        public Car(string carName)
        {
            Wheels = 4;
            Name = carName;
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is off");
        }

        public void GoForward()
        {
            Console.WriteLine("The " + Name + " now is going forward");
        }

        public void Reverse()
        {
            Console.WriteLine("The " + Name + " now is in reverse");
        }
    }
}
