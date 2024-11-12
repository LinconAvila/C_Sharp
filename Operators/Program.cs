using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            age++;
            age += 1;

            Console.WriteLine(age);
            
            age--;
            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming!";

            Console.WriteLine(name);


  
            Console.ReadLine();
        }
    }
}
