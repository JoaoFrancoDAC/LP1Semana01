using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Hello LP1!");

             string s = "Um tab\t e um copyright\u03A9";
             Console.WriteLine(s);

             string test = "using unicode characters: \u00A9";
             Console.WriteLine(test);

             string umaLetraPorLinha = "a\n b\nc\nd\ne\nf\ng\nh\ni\nj\nk\nl\nm\nn\no\np\nq\nr\ns\nt\nu\nv";
             Console.WriteLine(umaLetraPorLinha);


        }
    }
}
