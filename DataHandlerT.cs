using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a C# class named "DataHandler<T>" that simulates 
a data handler using generics. It should include the following
 methods:

A method "AddData" that adds an element of type T to the data 
handler.

A method "RetrieveData" that retrieves and returns an element 
from the data handler at a specific index.

Create an instance of "DataHandler" for integers and add some 
data to the handler. Use the "RetrieveData" method to retrieve 
and print data from the handler based on given indices.
*/
namespace Nini_Beridze2
{

    public class DataHandler<T>
    {
        private List<T> dataList;

        public DataHandler()
        {
            dataList = new List<T>();
        }

        public void AddData(T data)
        {
            dataList.Add(data);
        }

        public T RetrieveData(int index)
        {
            if (index < 0 || index >= dataList.Count)
            {
                throw new ArgumentOutOfRangeException("Out of range.");
            }//if it doesn't exist
            return dataList[index];
        }
    }

}
