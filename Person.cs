using System;

namespace ExercThree
{
    public class Person
    {
        private int age;
        private int height;
        private int weight;
        private string fName;
        private string lName;

        // Declaring rules for properties
        // where it's necessary.        
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Need to use a positive number");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length <= 10 && value.Length >= 2)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First name must contain between 2 to 10 characters");
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length <= 15 && value.Length >= 3)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must contain between 3 to 15 characters");
                }
            }
        }
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Name: {FName} {LName}, Age: {Age}.");
        }
    }
}
