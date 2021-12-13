using System;

namespace ExercThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's create a new object!
            Person emp = new Person();

            // Throw an exception if error caught with
            // try-catch method.

            try
            {
                //emp.Age = -2;
                //emp.FName = "jesse varis";
            }
            catch (ArgumentException e)
            {
                //Console.WriteLine("You need to use a positive integer.");
                //Console.WriteLine("You need to use between 2 to 10 letters.");

                //throw;
            }
            //int age = emp.Age;
            //Console.WriteLine(emp.Age);
            //Console.WriteLine(emp.FName);

        }
    }

}
