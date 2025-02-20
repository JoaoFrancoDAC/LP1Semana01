using System;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            int number = 1;
            Console.WriteLine(number);

            int binary_int = 0b1000_0001_0001_0001;
            Console.WriteLine(binary_int);

            int hexadecimal_int = 0xFF;
            Console.WriteLine(hexadecimal_int);

            uint second_number = 123456789u;
            Console.WriteLine(second_number);

            char copyrightSymbol = '\u00A9';
            Console.WriteLine(copyrightSymbol);

            char squareSymbol = '\u00A4';
            Console.WriteLine(squareSymbol);

            Char star = '\x2605';
            Console.WriteLine(star);

            char sigma = '\u03A3';
            Console.WriteLine(sigma);

            char anotherSigma = '\x2211';
            Console.WriteLine(anotherSigma);

            double pi = 3.14159;
            Console.WriteLine(pi);

            float e = 2.71828f;
            Console.WriteLine(e);

            decimal randomNumber = 123456789.0123456789m;
            Console.WriteLine(randomNumber);
            



            

         
        
        }
    }
}
