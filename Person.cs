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
            set {
                if ( age < 0)
                {
                    throw new ArgumentException(nameof(age));
                }
                age = value; }
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

        // This property
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        } 
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        
    }
}
