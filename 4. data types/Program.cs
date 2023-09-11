using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _4.data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 18;
            bool isTall = true;
            double weight = 80.2;

            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("his weiht is " + weight);

            name = " khathutshelo";
            age = 23;
            isTall = true;
            weight = 90;

            Console.WriteLine("His name is " + name +"\n" + " he is " + age +"\n " + " it is " + isTall + " that he is tall");
            Console.WriteLine("his weiht is " + weight);

            Console.ReadLine();

        }
    }
}
