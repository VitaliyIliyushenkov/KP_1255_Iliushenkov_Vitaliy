using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Password_Generator
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            try
            {
                //Параметры по умолчанию
                int length = 16;
                int min_num = 0;
                int min_letter = 0;
                bool ch = false;
                List<string> type = new List<string>() { "numbers", "small_letters" };

                //Конфигурация
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].Split('=')[0] == "--length" && i == 0)
                    {
                        length = int.Parse(args[i].Split('=')[1]);
                        Console.WriteLine(length);
                        ch = true;
                    }

                    else if (args[i].Split('=')[0] == "--digits")
                    {
                        min_num = int.Parse(args[i].Split('=')[1]);
                        if (min_num > length && !ch)
                            length = min_num;
                        min_letter = 0;
                    }
                    else if (args[i].Split('=')[0] == "--letters")
                    {
                        min_letter = int.Parse(args[i].Split('=')[1]);
                        if (min_letter > length && !ch)
                            length = min_letter;
                        min_num = 0;
                    }
                    else if ("--uppercase".Contains(args[i]))
                        type.Add("big_letters");

                    else if ("--special".Contains(args[i]))
                        type.Add("special_symbols");
                    else if (i == 0)
                    {
                        ch = true;
                        length = int.Parse(args[i]);
                    }
                    else
                    {
                        i = 0;
                    }
                }
                int count_letter;
                int count_num;
                string password;

                //генерация пароля
                do
                {
                    password = "";
                    count_letter = 0;
                    count_num = 0;

                    //Проверка
                    if (min_num + min_letter > length)
                    {
                        Console.WriteLine("Error");
                    }

                    for (int i = 0; i < length; i++)
                    {
                        int randomtype = rand.Next(type.Count);
                        if (type[randomtype] == "numbers")
                        {
                            password += GeneratorNumber();
                            count_num++;
                        }

                        if (type[randomtype] == "small_letters")
                        {
                            password += GeneratorSmallSymbol();
                            count_letter++;
                        }

                        if (type[randomtype] == "big_letters")
                        {
                            password += GeneratorBigSymbol();
                            count_letter++;
                        }

                        if (type[randomtype] == "special_symbols")
                            password += GeneratorSpecialSymbol();
                    }
                }
                while (min_letter > count_letter || min_num > count_num);
                Console.WriteLine(password);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        static string GeneratorNumber() //Генератор цифр
        {
            string value = rand.Next(0, 10).ToString();
            return value;
        }
        static char GeneratorBigSymbol() //Генератор Больших символов
        {
            char value = (char)rand.Next(65, 91);
            return value;
        }
        static char GeneratorSmallSymbol() //Генератор Маленьких символов
        {
            char value = (char)rand.Next(97, 123);
            return value;
        }
        static char GeneratorSpecialSymbol() //Генератор cпециальных символов
        {
            char value = (char)rand.Next(33, 38);
            return value;
        }
    }
}
