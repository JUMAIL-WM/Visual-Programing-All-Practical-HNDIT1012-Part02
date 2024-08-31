using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 2; i < 20; i=i+3)
            {
                if(i==8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            /*int x, y;
             x = 3;
             y = ++x * ++x;
             Console.WriteLine(x + y);
             Console.ReadLine();*/


            /*int x = 4;
            int y = x++ * ++x;
            Console.WriteLine(x + y);
            Console.ReadLine();*/

            /*String name = "JUMAIL";
            int height = 40;
            float weight = 50;
            bool isAStudent = true;
            char blood_group = 'B';

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("weight: " + weight);
            Console.WriteLine("is A Student: " + isAStudent);
            Console.WriteLine("Blood Group: " + blood_group);
            Console.ReadLine();*/

        }
    }
}
