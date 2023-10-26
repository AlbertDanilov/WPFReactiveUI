using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(null, null);

            tom.FirstName = "Tom";
            Console.WriteLine($"FirstName = {tom.FirstName}");
            Console.WriteLine($"FullName = {tom.FullName}");

            tom.LastName = "Hanson";
            Console.WriteLine($"LastName = {tom.LastName}");
            Console.WriteLine($"FullName = {tom.FullName}");

            //var observable = Enumerable.Range(1, 4).ToObservable();

            //observable.Subscribe(Observer.Create<int>(
            //        i => Console.WriteLine(i),                          //OnNext
            //        e => Console.WriteLine(e),                          //OnError
            //        () => Console.WriteLine("Taking numbers: complete") //OnCompleted
            //    ));

            //observable.Select(i => i * i).Subscribe(Observer.Create<int>(
            //        i => Console.WriteLine(i),                          //OnNext
            //        e => Console.WriteLine(e),                          //OnError
            //        () => Console.WriteLine("Taking squares: complete") //OnCompleted
            //    ));

            //observable.Take(2).Subscribe(Observer.Create<int>(
            //        i => Console.WriteLine(i),                          //OnNext
            //        e => Console.WriteLine(e),                          //OnError
            //        () => Console.WriteLine("Taking 2 items: complete") //OnCompleted
            //    ));

            //observable.Where(i => i % 2 != 0).Subscribe(Observer.Create<int>(
            //        i => Console.WriteLine(i),                              //OnNext
            //        e => Console.WriteLine(e),                              //OnError
            //        () => Console.WriteLine("Taking odd numbers: complete") //OnCompleted
            //    ));

            Console.ReadLine();
        }
    }
}
