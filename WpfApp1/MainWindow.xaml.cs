using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] alphabet = new char[] { ' ', 'a', 'b', 'c', 'd', 'e', 
                                       ' ', 'f', 'g', 'h', 'i', 'j',
                                       ' ', 'k', 'l', 'm', 'n', 'o',
                                       ' ', 'p', 'q', 'r', 's', 't',
                                       ' ', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
        List<string> dictionary = new List<string>();
        Random random = new Random();
        StringBuilder sb = new StringBuilder();


        private string _searchText;

        public string searchText {
            get { return _searchText; }
            set
            {
                _searchText = value;
                sb.Clear();
                foreach(string item in dictionary.Where(x => x.Contains(_searchText)).ToList())
                {
                    sb.AppendLine($"{item}");
                }

                Dispatcher.Invoke(() => {
                    textBlock_finded.Text = sb.ToString();
                });                
            }
        }


        public MainWindow()
        {
            InitializeComponent();

            dictionary.AddRange(Enumerable.Range(1, 100).Select(x => {
                sb.Clear();
                int maxIndex = random.Next(10, 100);
                for (int i = 0; i < maxIndex; i++)
                {
                    sb.Append(alphabet[random.Next(0, 25)]);
                }
                return sb.ToString();
            }).ToList());


            Observable.FromEventPattern(textBox_search, "TextChanged")
                      .Select(s => ((TextBox)s.Sender).Text)
                      .Throttle(TimeSpan.FromSeconds(1))
                      .DistinctUntilChanged()
                      .Subscribe(text => { 
                          searchText = text; 
                      });

        }

    }
}
