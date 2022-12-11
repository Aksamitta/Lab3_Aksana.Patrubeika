using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab3_Aksana.Patrubeika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            На вход передать строку(будем считать, что это номер документа). Номер документа имеет 
            формат xxxx - yyy - xxxx - yyy - xyxy, где x — это число, а y — это буква. 
            -Вывести на экран в одну строку два первых блока по 4 цифры.
            - Вывести на экран номер документа, но блоки из трех букв заменить на ***(каждая буква заменятся на *). 
            -Вывести на экран только одни буквы из номера документа в формате yyy / yyy / y / y в нижнем регистре.
                 - Вывести на экран буквы из номера документа в формате
            "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
            - Проверить содержит ли номер документа
            последовательность abc и
            вывети сообщение содержит или нет(причем, abc и ABC
            считается одинаковой последовательностью). 
            -Проверить начинается ли номер документа с последовательности 555.
            - Проверить заканчивается ли номер документа на
            последовательность 1a2b.
            Все эти методы реализовать в отдельном классе в статических методах, 
            которые на вход(входным параметром) будут принимать вводимую на вход программы строку.
                        */
            Console.WriteLine("Enter numbers of a document: ");
            //string[] documentNumber = { "8888", "ABC", "8888", "hHh", "8t8t" };
            //string a = ($"{documentNumber[0]}{documentNumber[1]}{documentNumber[2]}{documentNumber[3]}{documentNumber[4]}");
            string numbers = Console.ReadLine();
            string [] words = numbers.Split(new char[] {' '}); 
            Console.Clear();
            string newNumbers = String.Join("-", words);
            Console.WriteLine(newNumbers);

            IndexOf(newNumbers);
            Replace(newNumbers);
            deleteNumber(newNumbers);
            toLower(newNumbers);
            toUpper(newNumbers);
            check(newNumbers);
            checkStart(newNumbers);
            checkEnd(newNumbers);

            Console.ReadLine();
        }

       
        public static void IndexOf(string number)
        {
            var firstIndex = number.IndexOf('-');
            var secondIndex = number.IndexOf('-', firstIndex - 1);
            string part = number.Substring(0, secondIndex);
            var firstIndex1 = number.IndexOf('-', secondIndex - 1);
            string part2 = number.Substring(9, firstIndex1);
            Console.WriteLine($"{part}-{part2}");
        }

        public static void Replace(string number)
        {
            var newNunberSecond = number.Substring(18);
            //string newNumberFirst = number.Substring(0, 18);
            string newNumberFirst = new string(number.Substring(0, 18).Select(c => char.IsLetter(c) ? '*' : c).ToArray());
            string result = newNumberFirst.Insert(18, newNunberSecond);
            Console.WriteLine(result);
        }
        public static void deleteNumber(string number)
        {
            var delete = new Regex(@"\d");
            var delete2 = new Regex(@"\W");
            var newNumber = delete.Replace(number, String.Empty);
            var newNumber2 = delete2.Replace(newNumber, String.Empty).Insert(3, "/").Insert(7, "/").Insert(9, "/");
            Console.WriteLine(newNumber2); 
        }
        public static void toLower(string number)
        {
            //Console.WriteLine(number.ToLower());
            Console.WriteLine($"Letters: {number.ToLower()}");
        }

        public static void toUpper(string number)
        {
            //Console.WriteLine(number.ToLower());
            Console.WriteLine($"Letters: {number.ToUpper()}");
        }

        public static void check(string number)
        {
            string pattern = @"\w*abc\w*";
            if (Regex.IsMatch(number, pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine($"String contains abc");
            }
            else
            {
                Console.WriteLine($"String doesn't contain abc");
            }
        }
        public static void checkStart(string number)
        {
            string check3 = "555";
            if (number.StartsWith(check3))
            {
                Console.WriteLine($"String starts with {check3}");
            }
            else
            {
                Console.WriteLine($"String doesn't start with {check3}");
            }
        }
        public static void checkEnd(string number)
        {
            string check4 = "1a2b";
            if (number.EndsWith(check4))
            {
                Console.WriteLine($"String ends with {check4}");
            }
            else
            {
                Console.WriteLine($"String doesn't end with {check4}");
            }
        }
    }
}
