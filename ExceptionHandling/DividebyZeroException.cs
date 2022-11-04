using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    // Create class for DivideByZeroException
    internal class DivByZeroException
    {
        // Declaring Constructor
        public DivByZeroException()
        {
            try
            {
                // Assigning int value
                int randomNumber = 7730;

                // Create variable to assign value 0
                int zeroNumber = 0;

                //try to divide int with Zero
                int result = randomNumber / zeroNumber;

            }
            catch (DivideByZeroException DbzExc)
            {
                Console.WriteLine("DivideByZeroException has occured here");
                //print Exception Message
                Console.WriteLine(DbzExc.Message);
            }
        }
    }
}
