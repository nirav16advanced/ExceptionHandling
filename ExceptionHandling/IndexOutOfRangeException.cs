using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    // Create class for IndexOutOfRangeException
    internal class OutOfRangeException
    {
        //constructor
        public OutOfRangeException()
        {
            try
            {
                // Creating integer array with 5 values
                int[] myNumbers = { 1, 2, 3, 4, 5 };

                // Trying to iterate through value more than initial array
                for (int index = 0; index < 6; index++)
                {
                    Console.WriteLine(myNumbers[index]);
                }

            }
            catch (IndexOutOfRangeException IorExc)
            {
                Console.WriteLine("IndexOutOfRangeException has occured here");
                //print Exception Message
                Console.WriteLine(IorExc.Message);
            }
        }
    }
}
