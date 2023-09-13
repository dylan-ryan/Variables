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
            

            //int = interger whole numbers
            //float = numbers that arent whole
            //string = text


            int score;
            int enemyValue;
            string realName;
            string GamerTag;
            float percentile;


            score = 0;
            enemyValue = 200;
            realName = "Dylan Ryan";
            GamerTag = "gamertag";
            percentile = 85.543f;
            score = score + enemyValue;
            
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------------");
            Console.WriteLine();


            Console.WriteLine(realName + " (" + GamerTag + ")");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: " + percentile + "%");


            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
