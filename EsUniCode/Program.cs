using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsUniCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //string unicodeString = "This Unicode string has 2 characters outside the " + 
            //    "ASCII range: \n"+ 
            //    "Pi (\u03A0), and sigma (\u03A3)";

            Console.Write("Inserisci una frase: ");
            string unicodeString = Console.ReadLine();

            Console.WriteLine("Original string: ");
            Console.OutputEncoding = System.Text.Encoding.Unicode;//Questo comando serve per convertire dei simboli per poi stamparli a video in unicode.
            Console.WriteLine(unicodeString);
            Console.ReadLine();
        }
    }
}
