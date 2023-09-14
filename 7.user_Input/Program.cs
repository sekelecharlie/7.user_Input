using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.user_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Hi, " +  firstname);
            Console.WriteLine("Enter your Age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have " + age + " years. ");



            Console.ReadLine();
        }
        
    }
}
