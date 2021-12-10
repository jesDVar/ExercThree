using System;

namespace ExercThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's create a new object!
            Person emp = new Person();

            // Running some codeline for testing purpose

            Console.WriteLine(emp.Age);

            // Not accessible 'cause of the private field
            //Console.WriteLine(FName);

            // Throw an exception if error caught with
            // try-catch method.

            //Haven't fully got my head around this.

            //try
            //{
            //    emp.Age = 20;

            //}
            //catch (ArgumentException)
            //{

            //    throw;
            //}


        }
    }

}
