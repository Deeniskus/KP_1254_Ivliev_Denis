using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public static List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePasswordBTN_Click(object sender, EventArgs e)
        {
            //Заполняем поле логина
            LoginTB.Text = Account.Translate(FirstNameTB.Text) + Account.Translate(LastNameTB.Text);
            //Праматры для пароля
            string args = "--length=" + PasswordLengthNUD.Value.ToString();
            if (isUpperCaseNeededCB.Checked)
            {
                args += " -u";
            }
            if (isSpecSymbolsNeededCB.Checked)
            {
                args += " -s";
            }
            if (strictLettersNumCB.Checked)
            {
                args += " --letters=" + LettersNumNUD.Value.ToString();
            }
            if (strictDigitsNumCB.Checked)
            {
                args += " --digits=" + DigitsNumNUD.Value.ToString();
            }
            //Запускаем приложение, путь относительный
            PasswordTB.Text = RunApp("1.PasswordGenerator\\PasswordGenerator\\bin\\Debug\\PasswordGenerator.exe", args);
            //Создаём объект класса аккаунт
            Account account = new Account(FirstNameTB.Text, LastNameTB.Text, LoginTB.Text, PasswordTB.Text, BitthDatePicker.Value);
            //Добавляем в список аккаунтов
            accounts.Add(account);
            //Добавляем в контейнер аккаунтов
            AccountsLB.Items.Add(account.GetTitle());
        }
        string RunApp(string path, string args) //D:\c#projects\PasswordGenerator\PasswordGenerator\bin\Debug
        {
            // Создание объекта для запуска внешнего приложения
            Process process = new Process();

            process.StartInfo.FileName = path;                  // указание пути к файлу запускаемой программы
            process.StartInfo.Arguments = args;                // передача аргументов запускаемой программы
            process.StartInfo.UseShellExecute = false;          // false требуется, чтобы можно было читать из вывода запущенного приложения
            process.StartInfo.RedirectStandardOutput = true;    // true требуется, чтобы можно было читать из стандартного вывода запущенного приложения
            process.StartInfo.RedirectStandardError = true;     // true требуется, чтобы можно было читать из ошибки запущенного приложения
            process.StartInfo.CreateNoWindow = true;            // отключаем создание окна (на всякий случай)

            // Запускаем приложение
            bool started = process.Start();
            if (!started)
            {
                Console.WriteLine("Ошибка запуска приложения!");
                throw new Exception("Ошибка запуска приложения!");
            }

            // Читамем вывод приложения
            string output = process.StandardOutput.ReadToEnd();

            // Дождаемся окончания работы приложения и выходим
            process.WaitForExit();

            return output;
        }
        //Заполнение данных по клику
        private void AccountsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = AccountsLB.SelectedItem.ToString();
            foreach (Account account in accounts)
            {
                if (account.GetTitle().Equals(item))
                {
                    FirstNameTB.Text = account.firstName;
                    LastNameTB.Text = account.lastName;
                    LoginTB.Text = account.login;
                    PasswordTB.Text = account.password;
                    BitthDatePicker.Value = account.birthDate;
                }
            }
        }
    }
}
