using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();

            tom.FirstName = "Tom";
            Console.WriteLine($"FirstName = {tom.FirstName}");
            Console.WriteLine($"FullName = {tom.FullName}");

            tom.LastName = "Hanson";
            Console.WriteLine($"LastName = {tom.LastName}");
            Console.WriteLine($"FullName = {tom.FullName}");


            Console.ReadLine();
        }
    }
}
