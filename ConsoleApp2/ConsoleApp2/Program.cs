using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marksA: ");
            int marksA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your marksB: ");
            int marksB = int.Parse(Console.ReadLine());

            int Total = marksA + marksB;
            double avarage = Total / 2;

            Console.WriteLine("Total: "+ Total);
            Console.WriteLine("Avarage: "+ avarage);
            
           
            Console.ReadLine();
        }
    }
}
