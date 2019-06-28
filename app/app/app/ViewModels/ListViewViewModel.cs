using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace app.ViewModels
{
    public class ListViewViewModel
    { 
        public ObservableCollection<Person>PersonsList { get; set; }
        public ListViewViewModel()
        {
             PersonsList = new ObservableCollection<Person>
             {
                 new Person() {Name = "Sofia", Age = "1"},
                 new Person() {Name = "Caro", Age = "22"},
                 new Person() {Name = "Adri", Age = "20"},
                 new Person() {Name = "Néstor", Age = "20"},
                 new Person() {Name = "Copo", Age = "2"},

             }
        }
        public class Person
        {
            public string Name { get; set; }
            public string Age { get; set; }

        }
    }
}
