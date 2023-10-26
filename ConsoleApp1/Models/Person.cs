using ReactiveUI;
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
        public string FirstName
        {
            get => _firstName; 
            set {
                    this.RaiseAndSetIfChanged(ref _firstName, value);
                }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName; 
            set
            {
                this.RaiseAndSetIfChanged(ref _lastName, value);
            }
        }

        private readonly ObservableAsPropertyHelper<string> _fullName;
        public string FullName => _fullName.Value;


        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _fullName = this.WhenAnyValue(p => p.FirstName, p => p.LastName)
                            .Select(t => $"{t.Item1} {t.Item2}")
                            .ToProperty(this, p => p.FullName);
        }

    }
}
