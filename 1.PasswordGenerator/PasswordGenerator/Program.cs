using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static Random random = new Random();
        static int passwordLenght = 16;
        static int passwordDigitsNum = 8;
        static int passwordLettersNum = 8;
        static bool passwordIsUpperCaseNeeded = true;
        static bool passwordIsSpecialSymbolsNeeded = true;
        static string password;
        static void Main(string[] args)
        {
            //Обработка флагов
            CheckFlags(args);

            //Проверка на корректность запрашиваемого пароля
            if (IsPasswordDataCorrect())
            {
                password = GetPassword(passwordLenght, passwordDigitsNum, passwordLettersNum, passwordIsUpperCaseNeeded, passwordIsSpecialSymbolsNeeded);
            }

            //Вывод результата
            Console.WriteLine($"\nPassword: {password}\n");
            Console.WriteLine($"Lenght: {passwordLenght} {(passwordLenght == 16 ? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Letters: {passwordLettersNum} {(passwordLettersNum == 8 ? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Digits: {passwordDigitsNum} {(passwordDigitsNum == 8 ? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Special Symbols: {passwordLenght - passwordDigitsNum - passwordLettersNum}");
        }
        //Метод по получению пароя
        static string GetPassword(int length, int digitsNum, int lettersNum, bool isUpperCaseNeeded, bool isSpecialSymbolsNeeded)
        {
            string password = "";
            for (int i = 0; i < digitsNum; i++)
            {
                password += GetDigitChar();
            }

            if (isUpperCaseNeeded)
            {
                for (int i = 0; i < lettersNum; i++)
                {
                    password += GetRandomNumber(1, 2) == 2 ? GetUpperCaseChar() : GetLowerCaseChar();
                }
            }
            else
            {
                for (int i = 0; i < lettersNum; i++)
                {
                    password += GetLowerCaseChar();
                }
            }

            if (isSpecialSymbolsNeeded)
            {
                for (int i = 0; i < length - digitsNum - lettersNum; i++)
                {
                    password += GetSpecialSymbolChar();
                }
            }

            return Shuffle(password);




        }
        //Проверка на корректность запрашиваемого пароля + получение 
        static bool IsPasswordDataCorrect()
        {
            if (passwordLenght < (passwordDigitsNum + passwordLettersNum))
                throw new Exception("!!!Ошибка!!! Количество запрашиваемых символов больше длины пароля");
            else if (!passwordIsSpecialSymbolsNeeded && (passwordDigitsNum + passwordLettersNum) != passwordLenght)
                throw new Exception("!!!Ошибка!!! Недостаточное кол-во символов. Включите поддержку спец символов, либо увеличьте кол-во цифр или букв");
            else return true;
        }

        //Обработка флагов
        static void CheckFlags(string[] args)
        {
            if (args.Length != 0)
            {
                foreach (string arg in args)
                {
                    if (arg[0] != '-')
                    {
                        passwordLenght = Convert.ToInt32(args[0]);
                    }

                    if (arg[0] == '-' && arg[1] != '-')
                    {
                        foreach (char letter in arg)
                        {
                            if (letter == 'u') passwordIsUpperCaseNeeded = true;
                            if (letter == 's') passwordIsSpecialSymbolsNeeded = true;
                        }
                    }
                    if ((arg[0] == '-') && (arg[1] == '-'))
                    {
                        string[] splitedArg = arg.Split('=');
                        if (splitedArg[0] == "--lenght") passwordLenght = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--digits") passwordDigitsNum = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--letters") passwordLettersNum = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--uppercase") passwordIsUpperCaseNeeded = false;
                        if (splitedArg[0] == "--special") passwordIsSpecialSymbolsNeeded = false;
                    }
                }

            }
        }


        //Перемешать пароль
        static string Shuffle(string password)
        {
            for (int i = 0; i < passwordLenght; i++)
            {
                int randomPos = GetRandomNumber(0, passwordLenght - 1);
                char temp = password[randomPos];
                password = password.Remove(randomPos, 1).Insert(0, temp.ToString());
            }
            return password;
        }
        //Получить рандомное число (int)
        static int GetRandomNumber(int from, int to)
        {
            return random.Next(from, to + 1);
        }
        //Получить рандомную букву (в нижнем регистре)
        static char GetLowerCaseChar()
        {
            return (char)GetRandomNumber(97, 122);
        }
        //Получить рандомную букву (в верхнем регистре)
        static char GetUpperCaseChar()
        {
            return (char)GetRandomNumber(65, 90);
        }

        //Получить рандомное число (char)
        static char GetDigitChar()
        {
            return Convert.ToChar(GetRandomNumber(0, 9).ToString());
        }

        //Получить рандомный символ 
        static char GetSpecialSymbolChar()
        {
            return (char)GetRandomNumber(21, 46);
        }
    }
}
