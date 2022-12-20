using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefect_number
{
    class Program
    {
        static bool IsPerfect(int number)
        {
            int sum = 0;
            for(int i =1; i< number; i++)
            {
                if (number % i == 0) sum = sum + i; 
            
            }
            if (sum == number) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("enter the n1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("enter the n2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for(int i =n1; i<=n2; i++)
            {
                if (IsPerfect(i)) Console.WriteLine(i);

            }



        }
    }
}
