using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inteiro_a_ser_convertido = Console.ReadLine();
            Console.WriteLine($"inteiro ainda em formato de string: {inteiro_a_ser_convertido}");

            int numero_inteiro = Convert.ToInt32(inteiro_a_ser_convertido);
            Console.WriteLine($"inteiro convertido para inteiro: {numero_inteiro}");

            string real_a_ser_convertido = Console.ReadLine();
            Console.WriteLine($"real ainda em formato de string: {real_a_ser_convertido}");

            float real_convertido = float.Parse(real_a_ser_convertido);
            Console.WriteLine($"real convertido para float: {real_convertido}");

            Console.WriteLine($"Soma dos dois numeros: {real_convertido + numero_inteiro}");





        }
    }
}
