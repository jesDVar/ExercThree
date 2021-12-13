using System;

namespace ExercThree
{
    class Person
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
                    Console.WriteLine("Wrong input");
                    throw new ArgumentException(nameof(age));
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
                    throw new ArgumentException(nameof(fName));
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
                    throw new ArgumentException(nameof(lName));
                }
            }
        }
    }
}
