using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person : ReactiveObject
    {
        private string _firstName;
        [Reactive] public string FirstName { get; set; }

        private string _lastName;
        [Reactive] public string LastName { get; set; }

        private readonly ObservableAsPropertyHelper<string> _fullName;
        public string FullName => _fullName.Value;


        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _fullName = this.WhenAnyValue(p => p.FirstName, p => p.LastName)
                            .Select(t => $"{t.Item1} {t.Item2}")
                            //.Throttle(TimeSpan.FromSeconds(1))
                            .ToProperty(this, p => p.FullName);
        }

    }
}
