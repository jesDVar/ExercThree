using System;

namespace ExercThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var ph = new PersonHandler();
            ph.SeedPeople();
            ph.PrintAllPersons();

            //Let's create a new object!
            //Person pers = new Person("Jesse", "Varis.");

            // Use Try-Catch block.
            //try
            //{
            //    //emp.Age = -2;
            //    //pers.FName = "jesse varis";
            //}
            //catch (ArgumentException e)
            //{
            //    //Console.WriteLine("You need to use a positive integer.");
            //    //Console.WriteLine("You need to use between 2 to 10 letters.");
            //}

            //int age = emp.Age;
            //Console.WriteLine(emp.Age);
            //Console.WriteLine(emp.FName);
        }
    }
}
