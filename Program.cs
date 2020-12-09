using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOf = "Cole";
            Console.WriteLine("My name is " + nameOf);
            Console.WriteLine("What is your name?");
            nameOf = Console.ReadLine();
            Console.WriteLine("Hello " + nameOf);
        }
    }
}
