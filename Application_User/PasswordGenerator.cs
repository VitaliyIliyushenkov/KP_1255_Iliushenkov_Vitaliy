using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_User
{
    internal class PasswordGenerator
    {
        public string path_program = $@"{Environment.CurrentDirectory}\\Password_Generator\bin\Debug\Password_Generator.exe";
        public string RunApp(string path, string arg)
        {
            // Создание объекта для запуска внешнего приложения
            Process process = new Process();

            process.StartInfo.FileName = path_program;                  // указание пути к файлу запускаемой программы
            process.StartInfo.Arguments = arg;                // передача аргументов запускаемой программы
            process.StartInfo.UseShellExecute = false;          // false требуется, чтобы можно было читать из вывода запущенного приложения
            process.StartInfo.RedirectStandardOutput = true;    // true требуется, чтобы можно было читать из стандартного вывода запущенного приложения
            process.StartInfo.RedirectStandardError = true;     // true требуется, чтобы можно было читать из ошибки запущенного приложения
            process.StartInfo.CreateNoWindow = true;            // отключаем создание окна (на всякий случай) 

            // Запускаем приложение
            bool started = process.Start();

            if (!started)
            {
                return "Ошибка запуска приложения!";
            }

            // Читамем вывод приложения
            string output = process.StandardOutput.ReadToEnd();

            // Дождаемся окончания работы приложения и выходим
            process.WaitForExit();

            return output;
        }
    }
}
