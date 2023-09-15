using System;
namespace Uppgift_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vilken stad kommer du ifrån?");
            string Stad = Console.ReadLine();
            Console.WriteLine("vad är ditt drömresmål?");
            string resmål = Console.ReadLine();
            Console.WriteLine("hej " + Stad + "sbo. Jag hoppas att du får resa till " + resmål +".");
        }
    }
}