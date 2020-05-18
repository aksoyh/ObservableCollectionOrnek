using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionOrnek.Model
{
    public class Person
    {
        public int personID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public static IEnumerable<Person> getPeople()
        {
            ObservableCollection<Person> People = new ObservableCollection<Person>();
            People.Add(new Person { personID = 1, Name = "Hasan AKSOY", Title = "Senior Software Developer" });

            return People;
        }

    }
}
