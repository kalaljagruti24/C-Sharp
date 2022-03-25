using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    { 
            static void Main(string[] args)
            {
                int i;
                Console.WriteLine("Enter the no to print the table:- \n\n");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------For Loop Execution--------\n\n");
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine( i*n+"\n");

                }
                Console.WriteLine("\n");
            Console.ReadLine();
            }
        }
    }

