using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class TypeMismatchException
    {
        public TypeMismatchException()
        {
            try
            {
                //Create string array fruits 
                string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Kiwi" };

                //Creat int array price
                int[] price = { 100, 50, 300, 900, 250 };

                // Copying fruits array into price array
                Array.Copy(fruits, price, 2);
            }
            catch (ArrayTypeMismatchException AtmExc)
            {
                Console.WriteLine("ArrayTypeMismatchException has occured here");
                //print Exception Message
                Console.WriteLine(AtmExc.Message);
            }
        }
    }
}
