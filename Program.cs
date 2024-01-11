using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sara";
            int age = 5;
            bool isTall = false;
            double weight = 25.5;

            Console.WriteLine("Hi , " + name + "  You're  " + age + " years old" + "  and your weight is " + weight);
            Console.WriteLine("True or false, Are you tall? :  " + isTall);

            //Freeaze my console
            Console.ReadLine();
        }
    }
}