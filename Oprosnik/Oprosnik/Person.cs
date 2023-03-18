using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Person
    {

        public string FirstName;
        public string LastName;
        public int GroupNumber;
        public string Icecream;
        public List<string> Fruits;
        public string Education;
        public int Age;
        public int EducationInterest;

        public Person()
        {

        }

        public Person(string FirstName, string LastName, int GroupNumber, string Icecream, List<string> Fruits, string Education, int Age, int EducationInterest)
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
        //Получить строку типа Имя Фамилия номер группы
        public string GetTitle()
        {
            return FirstName + " " + LastName + " " + GroupNumber;
        }

        //Конвертация списка в строку
        public string ListToJsonString()
        {
            string ListString = "[";
            foreach (string item in Fruits)
            {
                ListString += "\"" + item.ToString() + "\",";
            }
            ListString = Form1.RemoveLastChars(ListString, 1);
            ListString += "]";
            return ListString;
        }

        //Конвертация в json
        public string ToJson()
        {
            string jsonString =
                "{\"FirstName\":" + "\"" + FirstName.ToString() + "\"" + ","
                + "\"LastName\":" + "\"" + LastName.ToString() + "\"" + ","
                + "\"GroupNumber\":" + GroupNumber.ToString() + ","
                + "\"Icecream\":" + "\"" + Icecream.ToString() + "\"" + ","
                + "\"Fruits\":" + this.ListToJsonString() + ","
                + "\"Education\":" + "\"" + Education.ToString() + "\"" + ","
                + "\"Age\":" + Age.ToString() + ","
                + "\"EducationInterest\":" + EducationInterest.ToString() + "}";
            return jsonString;
        }


    }
}
