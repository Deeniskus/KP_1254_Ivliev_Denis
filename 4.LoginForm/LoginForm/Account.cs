using System;
using System.Collections.Generic;

namespace LoginForm
{
    public class Account
    {
        public int id;
        public string firstName;
        public string lastName;
        public string login;
        public string password;
        public DateTime birthDate;
        public List<Permission> permissions;

        //Нулевой пользователь (Админ)
        public static Account AdminAccount = new Account(0, "Админ", "Админ", "AdminAdmin", "admin", new DateTime(1800, 1, 1), Permission.Admin);

        //Тестовые аккаунты
        public static Account ZeroAccount = new Account(1, "Денис", "Ивлиев", "DenisIvliev", "123", new DateTime(2004, 8, 23), Permission.DefaultUser);

        //Список аккаунтов
        public static List<Account> Accounts = new List<Account>() { AdminAccount, ZeroAccount};

        //Словарь
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
        //Конструктор c паролем
        public Account(int id, string firstName, string lastName, string login, string password, DateTime birthDate, List<Permission> permissions)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            this.birthDate = birthDate;
            this.permissions = permissions;
        }

        //Конструктор пустой
        public Account() { }

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
        
        //Получение имени + фамилии
        public string GetTitle()
        {
            return firstName + " " + lastName;
        }

        //Получение логина + пароля
        public string GetData()
        {
            return login + " " + password;
        }
    }
}
