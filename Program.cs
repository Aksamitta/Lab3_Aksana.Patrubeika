using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //string[] documentNumber = Console.ReadLine().Split(' ').ToArray();
            string[] documentNumber = { "8888", "ABC", "8888", "hHh", "8t8t" };
            string a = ($"{documentNumber[0]}{documentNumber[1]}{documentNumber[2]}{documentNumber[3]}{documentNumber[4]}");

            numbersOnly(documentNumber);
            

            
            var sb1 = new StringBuilder(a);
            sb1.Remove(0, 4);
            sb1.Remove(3, 4);
            sb1.Remove(6, 1);
            sb1.Remove(7, 1);
            string line2 = sb1.ToString();
            Console.WriteLine(line2);

            
            var sb2 = new StringBuilder(line2);
            sb2.Insert(3, "/");
            sb2.Insert(7, "/");
            sb2.Insert(9, "/");
            string line3 = sb2.ToString();

            Console.WriteLine(line3.ToLower());
            Console.WriteLine($"Letters: {line3.ToUpper()}");

            string check1 = "abc";
            string check2 = "ABC";
            if (a.Contains(check1) || a.Contains(check2))
            {
                Console.WriteLine($"String {a} contains {check1}/{check2}");
            }
            else 
            {
                Console.WriteLine($"String {a} doesn't contain {check1}/{check2}");
            }

            string check3 = "555";
            if (a.StartsWith(check3))
            {
                Console.WriteLine($"String starts with {check3}");
            }
            else
            {
                Console.WriteLine($"String doesn't start with {check3}");
            }

            string check4 = "1a2b";
            if (a.EndsWith(check4))
            {
                Console.WriteLine($"String starts with {check4}");
            }
            else
            {
                Console.WriteLine($"String doesn't start with {check4}");
            }






            Console.ReadLine();
        }
        //public static void line(string line)
        //{
        //    for (int i = 0; i < line.Length; i++)
        //    {
        //        if (i >= '0' && i <= '9')
        //        {
        //            line = line.Replace('c', '*');
        //        }
        //    }

        //    Console.WriteLine(line);
        //}

        public static void numbersOnly(string[] array)
        {
            Console.WriteLine($"{array[0]} {array[2]}");
            string a = ($"{array[0]}{array[1]}{array[2]}{array[3]}{array[4]}");
            var sb = new StringBuilder(a);
            int pos4 = 4;
            int pos5 = 5;
            int pos6 = 6;
            int pos11 = 11;
            int pos12 = 12;
            int pos13 = 13;
            char rep = '*';
            sb[pos4] = rep;
            sb[pos5] = rep;
            sb[pos6] = rep;
            sb[pos11] = rep;
            sb[pos12] = rep;
            sb[pos13] = rep;
            Console.WriteLine(sb);
        }
    }
}
