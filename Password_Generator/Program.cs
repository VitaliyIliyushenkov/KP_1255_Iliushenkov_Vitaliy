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
        enum Type:int
        {
            Integer,
            Small_Letter,
            Big_Letter,
            Special_Symbol
        }

        static int length;
        static int min_num;
        static int min_letter;
        static int count_num;
        static int count_letter;

        static List<int> type_list;
        static List<int> type_letter;

        static void Main(string[] args)
        {
            //Параметры по умолчанию
            string password = "";

            length = 16;
            min_num = 0;
            min_letter = 0;
            count_num = 0;
            count_letter = 0;

            type_list = new List<int>() { (int)Type.Integer, (int)Type.Small_Letter};
            type_letter = new List<int>() { (int)Type.Small_Letter };


            //Конфигурация
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i][0] == '-')
                    {
                        if (args[i][1] == '-')
                        {
                            if (args[i].Split('=')[0] == "--length")
                            {
                                length = int.Parse(args[i].Split('=')[1]);
                            }

                            if (args[i].Split('=')[0] == "--digits")
                            {
                                min_num = int.Parse(args[i].Split('=')[1]);
                                min_letter = 0;
                            }
                            if (args[i].Split('=')[0] == "--letters")
                            {
                                min_letter = int.Parse(args[i].Split('=')[1]);
                                min_num = 0;
                            }
                            if (args[i] == "--uppercase")
                            {
                                type_list.Add((int)Type.Big_Letter);
                                type_letter.Add((int)Type.Big_Letter);
                            }

                            if (args[i] == "--special")
                                type_list.Add((int)Type.Special_Symbol);
                        }
                        else
                        {
                            for (int j = 1; j < args[i].Length; j++)
                            {
                                if (args[i][j] == 'u')
                                {
                                    type_list.Add((int)Type.Big_Letter);
                                    type_letter.Add((int)Type.Big_Letter);
                                }
                                else if (args[i][j] == 's') type_list.Add((int)Type.Special_Symbol);
                                else throw new Exception();
                            }
                        }
                    }
                    else length = int.Parse(args[0]);
                }

                //Проверка
                if (min_num > length)
                    length = min_num;
                if (min_letter > length)
                    length = min_letter;

                // Console.WriteLine("{0},{1},{2}", length, min_num, min_letter);

                //генерация пароля
                for (int i = 0; i < length; i++)
                {
                    int randomtype = rand.Next(type_list.Count);

                    switch (type_list[randomtype])
                    {
                        case ((int)Type.Integer):
                            if (count_letter < min_letter && length - i == min_letter - count_letter)
                            {
                                int randomtypeletter = rand.Next(type_letter.Count);
                                switch (type_letter[randomtypeletter])
                                {
                                    case ((int)Type.Small_Letter):
                                        password += GeneratorSmallSymbol();
                                        count_letter++;
                                        break;
                                    case ((int)Type.Big_Letter):
                                        password += GeneratorBigSymbol();
                                        count_letter++;
                                        break;
                                }
                            }
                            else
                            {
                                password += GeneratorNumber();
                                count_num++;
                            }
                            break;

                        case ((int)Type.Small_Letter):
                            if (count_num < min_num && length - i == min_num - count_num)
                            {
                                password += GeneratorNumber();
                                count_num++;
                            }
                            else
                            {
                                password += GeneratorSmallSymbol();
                                count_letter++;
                            }
                            break;

                        case ((int)Type.Big_Letter):
                            if (count_num < min_num && length - i == min_num - count_num)
                            {
                                password += GeneratorNumber();
                                count_num++;
                            }
                            else
                            {
                                password += GeneratorBigSymbol();
                                count_letter++;
                            }
                            break;
                        case ((int)Type.Special_Symbol):
                            if (count_num < min_num && length - i == min_num - count_num)
                            {
                                password += GeneratorNumber();
                                count_num++;
                            }
                            else if (count_letter < min_letter && length - i == min_letter - count_letter)
                            {
                                int randomtypeletter = rand.Next(type_letter.Count);
                                switch (type_letter[randomtypeletter])
                                {
                                    case ((int)Type.Small_Letter):
                                        password += GeneratorSmallSymbol();
                                        count_letter++;
                                        break;
                                    case ((int)Type.Big_Letter):
                                        password += GeneratorBigSymbol();
                                        count_letter++;
                                        break;
                                }
                            }
                            else password += GeneratorSpecialSymbol();
                            break;
                    }
                }
                Console.WriteLine(password);
            }
            catch
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
