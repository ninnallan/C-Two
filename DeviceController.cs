using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Then, create a class "DeviceController" that implements
 the "IDevice" interface. The "DeviceController" class should 
 have a field for the device type (e.g., "TV," "Phone") and 
 should implement the "Activate()" method to display a message 
 like "The [DeviceType] is now active."

*/
namespace Nini_Beridze2
{
  public class DeviceController : IDevice
    {
        private string deviceType;

        public DeviceController(string type)
        {
            deviceType = type;
        }

        public void Activate()
        {
            Console.WriteLine($"The {deviceType} is now active.");
        }
    }

}
