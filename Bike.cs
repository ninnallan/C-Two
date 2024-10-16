using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a derived class "Bike" that also inherits from 
"Vehicle." In the "Bike" class, implement the "StartEngine()" 
method to display "Bike engine started" and implement the 
"Accelerate()" method to display "Bike is pedaling."
Create instances of both the "Car" and "Bike" classes. Call their
 "StartEngine()" and "Accelerate()" methods to display the 
 appropriate messages.
*/
namespace Nini_Beridze2
{
    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Bike is pedaling.");
        }
    }

}
