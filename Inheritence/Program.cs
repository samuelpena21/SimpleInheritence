using Inheritence.Interface;
using Inheritence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Inhenitance test. In this program the Vehicle interface is implemented in both classes: 
                Car.class and Motorcylce.class. Interfaces are like a contract where you have to use 
                everything that is declared in the contract already. This is usefull if you need that some
                classes whith common caracteristics in your program follow an especific behavior
            */
            Console.WriteLine("---------------Inhenitance test----------------");
            Car car1 = new Car("Honda Civic");
            TurnOn(car1);

            Motorcycle motorcycle = new Motorcycle("Suzuki AX100");
            TurnOn(motorcycle);

            Console.ReadLine();
        }

        public static void TurnOn(Vehicle vehicle)
        {
            vehicle.TurnOn();
        }

        public static void TurnOff(Vehicle vehicle)
        {
            vehicle.TurnOff();
        }

        public static void GoForward(Vehicle vehicle)
        {
            vehicle.GoForward();
        }
        public static void Reverse(Vehicle vehicle)
        {
            vehicle.Reverse();
        }
    }
}
