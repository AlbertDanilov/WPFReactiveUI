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
                    UpdateFullName();
                }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                this.RaiseAndSetIfChanged(ref _lastName, value);
                UpdateFullName();
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

        private void UpdateFullName()
        {
            FullName = $"{FirstName} {LastName}";
        }
    }
}
