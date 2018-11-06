using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleObject
{
    class Person : ObservableObject
    {
        public string Name { get; set; }

        int _age;
        public int Age {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
    }
}
