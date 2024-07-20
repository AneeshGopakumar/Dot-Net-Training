using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Loops_AstericPattern
    {
        static void Main2(string[] args)
        {
            
            //Pattern 1
            int astericLimit = 5;
            Console.WriteLine("-----Asteric pattern 1-----");
            for (int i = 1; i < astericLimit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
               Console.WriteLine();

            }
           

            //Pattern 2
            int astericLimit2 = 5;
            Console.WriteLine("-----Asteric pattern 2-----");
            for (int i = astericLimit2; i > 0; i--)
            {
                int k = 1;
                while (k <= (astericLimit2 - i))
                {
                    Console.Write(" ");
                    k++;
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= astericLimit2; i++)
            {
                int k = 1;
                while (k <= (astericLimit2 - i))
                {
                    Console.Write(" ");
                    k++;
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //Pattern 3
            int astericLimit3 = 8;
            Console.WriteLine("-----Asteric pattern 3-----");
            for (int i = 1; i <= astericLimit3; i++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i) {
                    case 1:
                    case 2:
                    case 7:
                    case 8: Console.Write("*" + " "); break;
                    default:Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 3:
                    case 6:
                    case 8: Console.Write("*" + " "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 4:
                    case 5:
                    case 8: Console.Write("*" + " "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 8: Console.Write("*" + " "); break;
                    case 5: Console.Write("\b*" + "  "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 4:
                    case 5:
                    case 8: Console.Write("*" + " "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 3:
                    case 6:
                    case 8: Console.Write("*" + " "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                switch (i)
                {
                    case 1:
                    case 2:
                    case 7:
                    case 8: Console.Write("*" + " "); break;
                    default: Console.Write(" " + " "); break;
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= astericLimit3; i++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
            
            //Pattern 3 - alternate approach
            int astericLimit4 = 8;
            Console.WriteLine("-----Asteric pattern 3 - alternate approach-----");
            for (int i = 1; i <= astericLimit4 + 1; i++)
            {
                for (int j = 1; j <= astericLimit4; j++)
                {

                    switch (i)
                    {
                        case 1: Console.Write("*" + " "); break;
                        case 2:
                            switch (j)
                            {
                                case 1:
                                case 2:
                                case 7:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 3:
                            switch (j)
                            {
                                case 1:
                                case 3:
                                case 6:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 4:
                            switch (j)
                            {
                                case 1:
                                case 4:
                                case 5:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 5:
                            switch (j)
                            {
                                case 1:
                                case 8: Console.Write("*" + " "); break;
                                case 5: Console.Write("\b*" + "  "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 6:
                            switch (j)
                            {
                                case 1:
                                case 4:
                                case 5:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 7:
                            switch (j)
                            {
                                case 1:
                                case 3:
                                case 6:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 8:
                            switch (j)
                            {
                                case 1:
                                case 2:
                                case 7:
                                case 8: Console.Write("*" + " "); break;
                                default: Console.Write(" " + " "); break;
                            }
                            break;
                        case 9: Console.Write("*" + " "); break;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
