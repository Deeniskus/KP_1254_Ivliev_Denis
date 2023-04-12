using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class PasswordHelper
    {
        public static string GetPassword(ProfileForm profileForm)
        {
            string args = "--length=" + profileForm.PasswordLengthNUD.Value.ToString();
            if (profileForm.isUpperCaseNeededCB.Checked) args += " -u";
            if (profileForm.isSpecSymbolsNeededCB.Checked) args += " -s";
            if (profileForm.strictLettersNumCB.Checked) args += " --letters=" + profileForm.LettersNumNUD.Value.ToString();
            if (profileForm.strictDigitsNumCB.Checked) args += " --digits=" + profileForm.DigitsNumNUD.Value.ToString();
            string password = RunApp("1.PasswordGenerator\\PasswordGenerator\\bin\\Debug\\PasswordGenerator.exe", args);

            return password;
        }
        static string RunApp(string path, string args) 
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
    }
}
