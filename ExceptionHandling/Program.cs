using ExceptionHandling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Object for ArrayTypeMismatchExeption
            TypeMismatchException typeMismatchException = new TypeMismatchException();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for DivideByZeroException
            DivByZeroException divbyzeroException = new DivByZeroException();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for InvalidCastingException
            CastingException castException = new CastingException();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for IndexOutOfRangeException
            OutOfRangeException outOfRangeException = new OutOfRangeException();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for IOException
            ExceptionIO exceptionIO = new ExceptionIO();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for NullReferenceException
            NullPointException nullPointException = new NullPointException();

            Console.WriteLine("------------------------------------------------------------------------");

            // Object for StackOverflowException
            StOverflowException overflowException = new StOverflowException();

            Console.WriteLine("------------------------------------------------------------------------");

        }
    }
}