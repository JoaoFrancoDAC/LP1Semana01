using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Insere código:");
            string numero_hexadecimal = Console.ReadLine();

            char caráter_unicode = (char)int.Parse(numero_hexadecimal, NumberStyles.HexNumber);
            Console.WriteLine($"O caractere correspondente é: {caráter_unicode}");

        }
    }
}
