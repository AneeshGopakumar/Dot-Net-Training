using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Loops
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("For each loop (begin)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nFor each loop (end)");

            Console.WriteLine("While loop (begin)");
            int whileindex=0;
            while(whileindex < 10)
            {
                Console.Write(whileindex + " ");
                whileindex++;
            }
            Console.WriteLine("\nWhile loop (end)");

            Console.WriteLine("Do While loop (begin)");
            int doindex = 0;
            do
            {
                Console.Write(doindex + " ");
                doindex++;
            } while (doindex < 10);
            Console.WriteLine("\nDo While loop (end)");
        }
    }
}
