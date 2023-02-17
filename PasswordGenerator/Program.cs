using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static Random random = new Random();
        static int passwordLenght = 16;
        static int passwordDigitsNum = 8;
        static int currentPasswordDigitsNum;
        static int passwordLettersNum = 8;
        static int currentPasswordLettersNum;
        static bool passwordIsUpperCaseNeeded = true;
        static bool passwordIsSpecialSymbolsNeeded = true;
        static string password;
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                if (args[0][0] != '-') passwordLenght = Convert.ToInt32(args[0]);

                if (args[0][0] == '-' && args[0][1] != '-')
                {
                    foreach (string arg in args)
                    {
                        if (arg == "-u") passwordIsUpperCaseNeeded = false;
                        if (arg == "-s") passwordIsSpecialSymbolsNeeded = false;
                        if (arg == "-us")
                    {
                        passwordIsUpperCaseNeeded = false;
                        passwordIsSpecialSymbolsNeeded = false;
                    }
                    }
                }
                if ((args[0][0] == '-') && (args[0][1] == '-'))
                {
                    foreach (string arg in args)
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


            if (passwordLenght < (passwordDigitsNum + passwordLettersNum)) throw new Exception("\n\n------------------------------------------------------------------------------------------\n !!!Ошибка!!! Количество запрашиваемых символов больше длины пароля\n------------------------------------------------------------------------------------------\n");
            else if (!passwordIsSpecialSymbolsNeeded && (passwordDigitsNum + passwordLettersNum) != passwordLenght) throw new Exception("\n\n------------------------------------------------------------------------------------------\n!!!Ошибка!!! Недостаточное кол-во символов. Включите поддержку спец символов, либо увеличьте кол-во цифр или букв\n------------------------------------------------------------------------------------------\n");
            else password = GetPassword(passwordLenght, passwordDigitsNum, passwordLettersNum, passwordIsUpperCaseNeeded, passwordIsSpecialSymbolsNeeded);

            Console.WriteLine($"\nPassword: {password}\n");
            Console.WriteLine($"Lenght: {passwordLenght} {(passwordLenght == 16? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Letters: {currentPasswordLettersNum} {(currentPasswordLettersNum == 8 ? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Digits: {currentPasswordDigitsNum} {(currentPasswordDigitsNum == 8 ? " - Значение по умолчанию" : "")}");
            Console.WriteLine($"Special Symbols: {passwordLenght - currentPasswordDigitsNum - currentPasswordLettersNum}");
        }

        static string GetPassword(int length, int digitsNum, int lettersNum, bool isUpperCaseNeeded, bool isSpecialSymbolsNeeded)
        {
            string prePassword = "";
            for (int i = 0; i < passwordLenght; i++)
            {
                prePassword += GetSymbol();
            }
            if ((currentPasswordDigitsNum == passwordDigitsNum) && (currentPasswordLettersNum == passwordLettersNum)) return prePassword;
            else
            {
                currentPasswordDigitsNum = 0;
                currentPasswordLettersNum = 0;
                return GetPassword(passwordLenght, passwordDigitsNum, passwordLettersNum, passwordIsUpperCaseNeeded, passwordIsSpecialSymbolsNeeded);
            }



        }

        static char GetSymbol()
        {
            int whatSymbol = random.Next(4);
            switch (whatSymbol)
            {
                case 0:
                    if (currentPasswordLettersNum < passwordLettersNum)
                    {
                        currentPasswordLettersNum += 1;
                        return GetLowerCaseChar();
                    }
                    else
                    return GetSymbol();
                case 1:
                    if (currentPasswordDigitsNum < passwordDigitsNum)
                    {
                        currentPasswordDigitsNum += 1;
                        return GetDigitChar();
                    }
                    else
                    return GetSymbol();
                case 2:
                    if (currentPasswordLettersNum < passwordLettersNum && passwordIsUpperCaseNeeded)
                    {
                        currentPasswordLettersNum += 1;
                        return GetUpperCaseChar();
                    }
                    else
                    return GetSymbol();
                case 3:
                    if (passwordIsSpecialSymbolsNeeded) 
                    return GetSpecialSymbolChar();
                    else
                    return GetSymbol();
                default: 
                    return GetSymbol();

            }
        }

        static int GetRandomNumber(int from, int to)
        {
            return random.Next(from, to+1);
        }

        static char GetLowerCaseChar()
        {
            return (char) GetRandomNumber(97,122);
        }
        static char GetUpperCaseChar()
        {
            return (char)GetRandomNumber(65, 90);
        }

        static char GetDigitChar()
        {
            return Convert.ToChar(GetRandomNumber(0, 9).ToString());
        }

        static char GetSpecialSymbolChar()
        {
            return (char) GetRandomNumber(21, 46);
        }
    }
}
