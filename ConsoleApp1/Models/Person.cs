using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            get { return _firstName; }
            set {
                    this.RaiseAndSetIfChanged(ref _firstName, value);
                }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _lastName, value);
            }
        }

        private string _fullName;
        public string FullName 
        { 
            get => _fullName;
            set 
            {
                this.RaiseAndSetIfChanged(ref _fullName, value);
            }
        }

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            this.WhenAnyValue(p => p.FirstName, p => p.LastName).Subscribe(t => UpdateFullName(t));
        }

        private void UpdateFullName((string, string) tuple)
        {
            FullName = $"{tuple.Item1} {tuple.Item2}";
        }
    }
}
