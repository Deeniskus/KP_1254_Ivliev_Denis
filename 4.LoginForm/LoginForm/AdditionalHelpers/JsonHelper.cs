using System;
using System.Collections.Generic;
using System.IO;

namespace LoginForm.AdditionalHelpers
{
    internal class JsonHelper
    {


        //Сериализация
        public static List<string> Serialize(List<Account> accounts)
        {
            List<string> results = new List<string>();
            string result1 = "[";
            string result2 = "[";
            foreach (Account account in accounts)
            {
                result1 += ConvertToJsonObject(account, false) + ",";
                result2 += ConvertToJsonObject(account, true) + ",";
            }
            result1 = result1.Remove(result1.Length - 1);
            result2 = result2.Remove(result2.Length - 1);
            result1 += "]";
            result2 += "]";
            results.Add(result1);
            results.Add(result2);
            return results;
        }

        //Десериализация
        //С подробным описание находится во втором задании (опроснике)
        public static List<Account> DeserializeUserInfo(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<Account>() { Account.AdminAccount, Account.ZeroAccount };
            }
            else
            {
                List<Account> accounts = new List<Account>();
                string jsonIputString = File.ReadAllText(fileName);
                for (int i = 0; i < jsonIputString.Length; i++)
                {
                    Account account = new Account();

                    if (jsonIputString[i] == '{')
                    {
                        int currentPos = i;
                        int start;
                        int end;
                        bool breakFlag = false;
                        while (!breakFlag)
                        {
                            List<string> key_value = new List<string>();
                            start = jsonIputString.IndexOf('"', currentPos);
                            currentPos = start + 1;
                            end = jsonIputString.IndexOf('"', currentPos);
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            start = jsonIputString.IndexOf(':', currentPos);
                            currentPos = start + 1;
                            if (jsonIputString[currentPos] == '[')
                            {
                                end = jsonIputString.IndexOf(']', currentPos) + 1;
                            }
                            else
                            {

                                end = jsonIputString.IndexOf(',', currentPos);
                                if (end == -1)
                                {
                                    end = jsonIputString.IndexOf('}', currentPos);
                                    breakFlag = true;
                                }
                                else if (jsonIputString[end - 1] == '}')
                                {
                                    end -= 1;
                                    breakFlag = true;
                                }

                            }
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            switch (key_value[0])
                            {
                                case "Id":
                                    account.id = Convert.ToInt32(key_value[1]);
                                    break;
                                case "FirstName":
                                    account.firstName = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "LastName":
                                    account.lastName = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "Login":
                                    account.login = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "BirthDate":
                                    account.birthDate = new DateTime(Convert.ToInt32(key_value[1].Substring(7, 4)),
                                                                     Convert.ToInt32(key_value[1].Substring(4, 2)),
                                                                     Convert.ToInt32(key_value[1].Substring(1, 2)));
                                    break;
                                case "Permissions":
                                    key_value[1] = key_value[1].Substring(1, key_value[1].Length - 2);
                                    if (key_value[1].Equals("Admin"))
                                    {
                                        account.permissions = Permission.Admin;
                                    }
                                    if (key_value[1].Equals("DefaultUser"))
                                    {
                                        account.permissions = Permission.DefaultUser;
                                    }
                                    if (key_value[1].Equals("Guest"))
                                    {
                                        account.permissions = Permission.Guest;
                                    }
                                    break;
                            }
                        }
                        accounts.Add(account);
                    }

                }
                return accounts;
            }
        }
        public static void DeserializePasswords(string fileName)
        {
            if (File.Exists(fileName))
            {
                string jsonIputString = File.ReadAllText(fileName);
                int index = -1;
                int start = 0;
                int end = 0;
                bool found = false;
                for (int i = 0; i < jsonIputString.Length; i++)
                {
                    if (jsonIputString[i] == ':')
                    {
                        start = i + 2;
                        i += 2;
                        index += 1;
                        found = true;
                    }
                    if (jsonIputString[i] == '"' && found)
                    {
                        end = i;
                        Account.Accounts[index].password = jsonIputString.Substring(start, end - start);
                        found = false;
                    }
                }
            }
        }

        //Конвертация списка в строку
        public static string PermissionToJson(List<Permission> permissions)
        {
            if (permissions == Permission.Admin)
            {
                return "Admin";
            }
            if (permissions == Permission.DefaultUser)
            {
                return "DefaultUser";
            }
            if (permissions == Permission.Guest)
            {
                return "Guest";
            }
            return string.Empty;
        }

        //Конвертация в json
        static string ConvertToJsonObject(Account account, bool isPasswordNeeded)
        {
            string jsonString;
            if (isPasswordNeeded)
            {
                jsonString =
                "{\"Password\":" + "\"" + account.password + "\"" + "}";
            }
            else
            {
                jsonString =
                "{\"Id\":" + account.id.ToString() + ","
                + "\"FirstName\":" + "\"" + account.firstName + "\"" + ","
                + "\"LastName\":" + "\"" + account.lastName + "\"" + ","
                + "\"Login\":" + "\"" + account.login + "\"" + ","
                + "\"BirthDate\":" + "\"" + account.birthDate.ToString("d") + "\"" + ","
                + "\"Permissions\":" + "\"" + PermissionToJson(account.permissions) + "\"" + "}";
            }
            return jsonString;
        }
    }
}
