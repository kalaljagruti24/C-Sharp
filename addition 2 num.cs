using System;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("Enter  number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2 + num3;

            Console.WriteLine("{0} + {1} + {2} ={3}",num1,num2, num3 ,result);

             
                
        }
    }
}

