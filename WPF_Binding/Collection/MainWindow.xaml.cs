using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> _people; 
        public MainWindow()
        {
            InitializeComponent();
            _people = new List<Person>
            {
                new Person{ Name = "Bort", Age = 10},
                new Person{ Name = "Homie", Age = 45},
                new Person{ Name = "Marge", Age = 35},
                new Person{ Name = "Lisa", Age = 12},
                new Person{ Name = "Maggie", Age = 1},
            };
            _list.ItemsSource = _people;
        }
    }
}
