using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    //creating class StackOverflowException 
    internal class StOverflowException
    {
        //constructor
        public StOverflowException()
        {
            try
            {
                //calling Recursive method
                RecursiveMethod(0);
            }
            catch (StackOverflowException soEx)
            {
                Console.WriteLine("StackOverflowException has occured here");
                //print Exception Message
                Console.WriteLine(soEx.Message);
            }
        }

        public void RecursiveMethod(int myNumber)
        {
            //calling recursive method again and again
            RecursiveMethod(++myNumber);
        }
    }
}
