using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercThree
{
    public class PersonHandler
    {
        private List<Person> persons;

        public PersonHandler()
        {
            persons = new List<Person>();
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
    }
}

