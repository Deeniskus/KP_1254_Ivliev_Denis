using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class Person
    {

        public string FirstName;
        public string LastName;
        public string GroupNumber;
        public string Icecream;
        public List<string> Fruits;
        public string Education;
        public int Age;
        public int EducationInterest;

        public Person(string FirstName, string LastName, string GroupNumber, string Icecream, List<string> Fruits, string Education, int Age, int EducationInterest)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.GroupNumber = GroupNumber;
            this.Icecream = Icecream;
            this.Fruits = Fruits;
            this.Education = Education;
            this.Age = Age;
            this.EducationInterest = EducationInterest;
        }


    }
}
