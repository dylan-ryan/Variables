using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------------");
            Console.WriteLine();

            int score;

            score = 0;

            score = score + 100;

            Console.WriteLine("Score: " + score);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
