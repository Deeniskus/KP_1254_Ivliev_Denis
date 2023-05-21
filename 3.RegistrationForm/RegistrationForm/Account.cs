using System;
using System.Collections.Generic;

namespace RegistrationForm
{
    public class Account
    {
        public string firstName;
        public string lastName;
        public string login;
        public string password;
        public DateTime birthDate;
        public static Dictionary<string, string> alphabetDict = new Dictionary<string, string>
        {
            ["а"] = "a",
            ["б"] = "b",
            ["в"] = "v",
            ["г"] = "g",
            ["д"] = "d",
            ["е"] = "e",
            ["ё"] = "yo",
            ["ж"] = "zh",
            ["з"] = "z",
            ["и"] = "i",
            ["к"] = "k",
            ["л"] = "l",
            ["м"] = "m",
            ["н"] = "n",
            ["о"] = "o",
            ["п"] = "p",
            ["р"] = "r",
            ["с"] = "s",
            ["т"] = "t",
            ["у"] = "u",
            ["ф"] = "f",
            ["х"] = "kh",
            ["ц"] = "ts",
            ["щ"] = "sch",
            ["ч"] = "ch",
            ["э"] = "eh",
            ["ы"] = "y",
            ["ю"] = "you",
            ["я"] = "ya",
            ["й"] = "iy",
            ["А"] = "A",
            ["Б"] = "B",
            ["В"] = "V",
            ["Г"] = "G",
            ["Д"] = "D",
            ["Е"] = "E",
            ["Ё"] = "Yo",
            ["Ж"] = "Zh",
            ["З"] = "Z",
            ["И"] = "I",
            ["К"] = "K",
            ["Л"] = "L",
            ["М"] = "M",
            ["Н"] = "N",
            ["О"] = "O",
            ["П"] = "P",
            ["Р"] = "R",
            ["С"] = "S",
            ["Т"] = "T",
            ["У"] = "U",
            ["Ф"] = "F",
            ["Х"] = "Kh",
            ["Ц"] = "Ts",
            ["Щ"] = "Sch",
            ["Э"] = "Eh",
            ["Ы"] = "Y",
            ["Ю"] = "You",
            ["Я"] = "Ya",
            ["Й"] = "Iy",
            [" "] = " ",
            ["Ч"] = "Ch"
        };
        //Перевод транслитом
        public static string Translate(string word)
        {
            string translatedWord = string.Empty;
            foreach (char letter in word)
            {
                translatedWord += alphabetDict[letter.ToString()];
            }
            return translatedWord;
        }
        public Account(string firstName, string lastName, string login, string password, DateTime birthDate)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            this.birthDate = birthDate;

        }

        public string GetTitle()
        {
            return firstName+ " " + lastName;
        }
    }
}
