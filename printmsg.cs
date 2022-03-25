/* Name:- Kalal Jagruti Machhindra
    Class:- SYBCA (32)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
     class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            Console.Write("Enter The Number:-\n");
             n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("--------Do-While Loop Execution--------\n");
            do
            {
                Console.Write(i * n + "\n");
                i++;
            }
            while (i <= 10);
        }
    }
}
