using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            
            Console.WriteLine("digite um numero inteiro");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite um numero inteiro");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1*num2}");
            Console.ReadKey();
        }
    }
}
