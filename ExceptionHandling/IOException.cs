using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    //creating class for IOException
    public class ExceptionIO
    {
        //constructor
        public ExceptionIO()
        {
            try
            {
                //try to read file with invalid path give IOException
                string demoText = File.ReadAllText(@"../Exceptiontest.txt");
                Console.WriteLine(demoText);

            }
            catch (IOException IoExc)
            {
                Console.WriteLine("IOException has occured here");
                //print Exception Message
                Console.WriteLine(IoExc.Message);
            }
        }
    }
}
