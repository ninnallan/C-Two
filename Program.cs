using Nini_Beridze2;
/*Create an interface called "IDevice" with a method 
"Activate()" that represents activating a device.
*/
public interface IDevice
{
    void Activate();
}
/*
Create an instance of "DataHandler" for integers and add some 
data to the handler. Use the "RetrieveData" method to retrieve 
and print data from the handler based on given indices.*/
public class Program
{
    static void Main(string[] args)
    {

        DataHandler<int> intHandler = new DataHandler<int>();

        intHandler.AddData(1);
        intHandler.AddData(2);
        intHandler.AddData(3);

        try
        {
            Console.WriteLine(intHandler.RetrieveData(0));
            Console.WriteLine(intHandler.RetrieveData(1));
            Console.WriteLine(intHandler.RetrieveData(2));
        }
    
    }
/*Create an instance of the "DeviceController" class for a device with
 a specific type and call the "Activate()" method to display the 
 activation message.*/
    public static void Main()
    {
        DeviceController tvController = new DeviceController("TV");
        tvController.Activate();
        DeviceController phoneController = new DeviceController("Phone");
        phoneController.Activate();
    }

   public static void Main2(string[] args)
    {
        Vehicle myCar = new Car();
        myCar.StartEngine();
        myCar.Accelerate();

        Vehicle myBike = new Bike();
        myBike.StartEngine(); 
        myBike.Accelerate(); 
    }
}
