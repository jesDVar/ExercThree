using System.Collections.Generic;

namespace ExercThree
{
    public class PersonHandler
    {
        //Where we collect all our persons.
        private List<Person> persons;

        public PersonHandler()
        {
            persons = new List<Person>();
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(string fname, string lname, int age)
        {
            var person = new Person(fname, lname);
            SetAge(person, age);
            persons.Add(person);
            return person;
        }

        public void PrintAllPersons()
        {
            foreach (var person in persons)
                person.PrintPersonInfo();
        }
        public void SeedPeople()
        {
            CreatePerson("Jesse", "Varis", 39);
            CreatePerson("Jacqueline", "Andersson", 29);
            CreatePerson("Pelle", "Hansson", 79);
        }
    }
}

