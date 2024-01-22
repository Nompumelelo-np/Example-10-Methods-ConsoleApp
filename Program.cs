using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10_Methods_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling methods, AKA functions

            SayHi();

            //Method with parameters

            SayHiUser("Nompumelelo");

            SayHiAge("Nompumelelo", 25);

            
            Console.ReadLine();


        }
        static void SayHi()
        {
            Console.WriteLine(" Hi ");
        }
        static void SayHiUser(string name)
        { Console.WriteLine(" Hello " + name); 
        }
        static void SayHiAge(string name, int age)
        { Console.WriteLine(" Hello " + name + " you are " + age);
        }
    }
}
