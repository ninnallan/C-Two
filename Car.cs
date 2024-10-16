using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a derived class "Car" that inherits from "Vehicle." 
In the "Car" class, implement the "Start Engine()" method to 
display "Car engine started" and implement the "Accelerate()" 
method to display "Car is accelerating."
Create instances of both the "Car" and "Bike" classes. Call their
 "StartEngine()" and "Accelerate()" methods to display the 
 appropriate messages.
*/
namespace Nini_Beridze2
{
    using System;

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }
    }

}
