using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            
            Console.WriteLine($"{xx:F2}");
            Console.WriteLine($"Porcentagem com uma casa decimal do numero xx é: {xx:P1}");

            Console.WriteLine($"{ii:X}");
            Console.WriteLine($"ii formatado na notação de moeda de moeda: {ii:C}");


            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Hello LP1!");

             string s = "Um tab\t e um copyright\u03A9";
             Console.WriteLine(s);

             string test = "using unicode characters: \u00A9";
             Console.WriteLine(test);

             string umaLetraPorLinha = "a\n b\nc\nd\ne\nf\ng\nh\ni\nj\nk\nl\nm\nn\no\np\nq\nr\ns\nt\nu\nv";
             Console.WriteLine(umaLetraPorLinha);

             string concatenacao = "Concatenando " + "strings em C#";
             Console.WriteLine(concatenacao);

             int numero = 10;
             string concatenacaoComNumero = "Concatenando " + numero + " " + 1 + " " + concatenacao;
             Console.WriteLine(concatenacaoComNumero);

             Console.WriteLine($"Formatando usando a interpolacao: {numero}");
             Console.WriteLine($"isso funciona?{10+numero}");

             string interpolacao = $"Formatando usando a interpolacao: {numero} e {umaLetraPorLinha}";
             Console.WriteLine(interpolacao);




        }
    }
}
