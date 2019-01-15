using Inheritence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence.Models
{
    class Motorcycle : Vehicle
    {
        public int Wheels { get; set; }

        public string Name { get; set; }

        public Motorcycle()
        {
            Wheels = 2;
        }

        public Motorcycle(string motorcycleName)
        {
            Wheels = 2;
            Name = motorcycleName;
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
