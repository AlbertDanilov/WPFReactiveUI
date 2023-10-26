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
    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set {
                    if (value == _firstName) return;
                    _firstName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _fullName;
        public string FullName 
        { 
            get => _fullName;
            set { _fullName = FirstName; }
        }
    }
}
