using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program : ReactiveObject
    {
        static void Main(string[] args)
        {
            //Person tom = new Person(null, null);

            //tom.FirstName = "Tom";
            //Console.WriteLine($"FirstName = {tom.FirstName}");
            //Console.WriteLine($"FullName = {tom.FullName}");

            //tom.LastName = "Hanson";
            //Console.WriteLine($"LastName = {tom.LastName}");
            //Console.WriteLine($"FullName = {tom.FullName}");


            //----------------------------------------------------------------------------------------


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


            //----------------------------------------------------------------------------------------


            //var people = new ObservableCollection<Person>();

            //people.CollectionChanged += People_CollectionChanged;


            //void People_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            //{
            //    switch (e.Action)
            //    {
            //        case NotifyCollectionChangedAction.Add: // если добавление
            //            if (e.NewItems?[0] is Person newPerson)
            //                Console.WriteLine($"Добавлен новый объект: {newPerson.FirstName}");
            //            break;
            //        case NotifyCollectionChangedAction.Remove: // если удаление
            //            if (e.OldItems?[0] is Person oldPerson)
            //                Console.WriteLine($"Удален объект: {oldPerson.FirstName}");
            //            break;
            //        case NotifyCollectionChangedAction.Replace: // если замена
            //            if ((e.NewItems?[0] is Person replacingPerson) &&
            //                (e.OldItems?[0] is Person replacedPerson))
            //                Console.WriteLine($"Объект {replacedPerson.FirstName} заменен объектом {replacingPerson.FirstName}");
            //            break;
            //    }
            //}

            //people.AddRange(Enumerable.Range(1, 100).Select(p => new Person($"{p}", $"{p}")));

            //----------------------------------------------------------------------------------------


            //ObservableCollection<string> itemsList = new ObservableCollection<string>();

            //var itemsCache = itemsList.ToObservableChangeSet().AsObservableList().Connect().Subscribe(x => {
            //    Console.WriteLine($"\ncount = {x.Count}");
            //    foreach (var item in x) { Console.WriteLine($"Reason = {item.Reason}, Current = {item.Item.Current}, Previous = {item.Item.Previous}"); }
            //});

            //itemsList.Add("a");
            //itemsList.Add("b");
            //itemsList[0] = "c";
            //itemsList.RemoveAt(0);


            //----------------------------------------------------------------------------------------


            //string s = string.Empty;
            //string pattern = string.Empty;

            ////s = "Бык Тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            ////pattern = @"туп(\w*)";

            //s = "123-123-1234";
            //pattern = @"[0-9]{3}-\d{3}-\d{3}4$";

            //Regex regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //var isMatch = regex.IsMatch(s);
            ////MatchCollection matches = regex.Matches(s);

            Console.ReadLine();
        }
    }
}
