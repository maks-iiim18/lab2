using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("---------------Типы-------------------");
            //int a1;
            //float b1;
            //double c1;
            //bool d1;
            //decimal e1;
            //char f1;
            //long g1;
            //Console.WriteLine("Введите переменную типа int: ");
            //a1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа float: ");
            //b1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа double: ");
            //c1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа bool: ");
            //d1 = bool.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа decimal: ");
            //e1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа char: ");
            //f1 = char.Parse(Console.ReadLine());
            //Console.WriteLine("Введите переменную типа long: ");
            //g1 = long.Parse(Console.ReadLine());
            ////---------------------------------------------------------
            //Console.WriteLine("Переменная типа int: {0}", a1);
            //Console.WriteLine("Переменная типа float: {0}", b1);
            //Console.WriteLine("Переменная типа double: {0}", c1);
            //Console.WriteLine("Переменная типа bool: {0}", d1);
            //Console.WriteLine("Переменная типа decimal: {0}", e1);
            //Console.WriteLine("Переменная типа char: {0}", f1);
            //Console.WriteLine("Переменная типа long: {0}", g1);
            ////---------------------------------------------------------
            ////---------------------------------------------------------
            //byte a21 = (byte)a1;
            //Console.WriteLine("Явное преобразование int в byte: {0}", a21);
            //long b21 = (long)a1;
            //Console.WriteLine("Явное преобразование int в long: {0}", a21);
            //uint c21 = (uint)a1;
            //Console.WriteLine("Явное преобразование int в uint: {0}", c21);
            //decimal d21 = (decimal)e1;
            //Console.WriteLine("Явное преобразование int в decimal: {0}", d21);
            //int e21 = (int)b1;
            //Console.WriteLine("Явное преобразование float в int: {0}", e21);
            ////-----------------------------------------------------------
            //long a22 = a1;
            //Console.WriteLine("Неявное преобразование int в long: {0}", a22);
            //double b22 = a1;
            //Console.WriteLine("Неявное преобразование int в double: {0}", b22);
            //decimal c22 = a1;
            //Console.WriteLine("Неявное преобразование int в decimal: {0}", c22);
            //double d22 = g1;
            //Console.WriteLine("Неявное преобразование long в double: {0}", d22);
            //decimal e22 = g1;
            //Console.WriteLine("Неявное преобразование long в decimal: {0}", e22);
            ////----------------------------------------------------------------
            //bool b = true;
            //double d = Convert.ToDouble(b);
            //Console.WriteLine("Преобразование bool в double с использованием Convert: {0}", d);
            ////---------------------------------------------------------
            ////---------------------------------------------------------
            //int x = 5;
            //Object o = x; //упаковка
            //byte m = (byte)(int)o;//распаковка и приведение типа
            //Console.WriteLine("Упаковка и распаковка с приведением типа переменной x: {0}", m);
            ////---------------------------------------------------------
            ////---------------------------------------------------------
            //var s1 = 5;
            //var s2 = 45;
            //var s0 = (s1 + s2) / s1;
            //Console.WriteLine("Работа с неявно типизированной переменной: s0 = (s1 + s2) / s1 = {0}", s0);
            ////---------------------------------------------------------
            ////---------------------------------------------------------
            //int? x1 = null;
            //Console.WriteLine("Nullable переменная: {0}", x1);
            //Nullable<int> x2 = 5;
            //Console.WriteLine("Nullable переменная: {0}", x2);
            ////----------------------------------------------------------
            ////var perem = 5;
            ////perem = f;
            //Console.WriteLine("----------------------------Строки--------------------------------");
            //string stroke1 = "Maksim";
            //string stroke2 = "Dyadyuk";
            //Console.WriteLine("Строка s1: {0}", stroke1);
            //Console.WriteLine("Строка s2: {0}", stroke2);
            //int result = String.Compare(stroke1, stroke2);
            //if (result < 0)
            //{
            //    Console.WriteLine("Строка s1 перед строкой s2");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Строка s1 стоит после строкой s2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки s1 и s2 идентичны");
            //}
            ////---------------------------------------------------------------------------------
            //Console.WriteLine("                                                                                  ");
            //string str1 = "hello";
            //string str2 = " world";
            //string str3 = "!!!";
            //Console.WriteLine("Строка str1: {0}", str1);
            //Console.WriteLine("Строка str2: {0}", str2);
            //Console.WriteLine("Строка str3: {0}", str3);
            //string str4 = String.Concat(str1, str2, str3);
            //Console.WriteLine("Сцепленная строка: {0}", str4);
            //string str5 = String.Copy(str4);
            //Console.WriteLine("Скопированная строка: {0}", str5);
            //string str6 = str4.Substring(2, 5);
            //Console.WriteLine("Выделенная подстрока: {0}", str6);
            //string text = "И поэтому все так произошло";
            //string[] words = text.Split(new char[] { ' ' });
            //foreach(string str7 in words)
            //{
            //    Console.WriteLine("Разделенная строка: {0}", str7);
            //}
            //string text1 = "Факультет ";
            //string subString = "Информационных Технологий";
            //text1 = text1.Insert(10, subString);
            //Console.WriteLine("Вставка подстроки: {0}", text1);
            //string text2 = "Хороший день";
            //text2 = text2.Remove(0, 4);
            //Console.WriteLine("Удаление заданной подстроки: {0}", text2);
            //double a = 3;
            //double k= 4;
            //Console.WriteLine($"Площадь треугольника с катетами {a}, {k} равняется {0.5 * a * k}");
            //string proverka1 = "";
            //string proverka2 = null;
            //string proverka3 = "Hello";
            //Console.WriteLine(String.IsNullOrEmpty(proverka1));
            //Console.WriteLine(String.IsNullOrEmpty(proverka2));
            //Console.WriteLine(String.IsNullOrEmpty(proverka3));
            //Console.WriteLine("   StringBuilder   ");
            //StringBuilder sb = new StringBuilder("ABC", 50);
            //Console.WriteLine(sb);
            ////Добавряем 3 символа в конец
            //sb.Append(new char[] { 'D', 'E', 'F' });
            //Console.WriteLine(sb);
            ////Добавляем текст в начало 
            //sb.Insert(0, "Alphabet: ");
            //Console.WriteLine(sb);
            Console.WriteLine("------------------------Массивы---------------------------");
            int[,] arr = new int[3, 3] { {1,2,3 },{4, 5 ,6 }, {7,8,9 } };
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);
            Console.WriteLine("                                                               ");
            string[] weekDays = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int kolich = weekDays.Length;
            for (int i = 0; i < weekDays.Length; i++)
                Console.Write(" " + weekDays[i]);
            Console.WriteLine(" ");
            Console.WriteLine("Количество элементов в массиве: {0}", kolich);
            Console.WriteLine("                                                               ");
            int[][] nums = new int[3][];
            nums[0] = new int[2];          // выделяем память для первого подмассива
            nums[1] = new int[3];       // выделяем память для второго подмассива
            nums[2] = new int[5]; // выделяем память для третьего подмассива
            foreach (int[] x in nums)
            {
                foreach (int nums1 in x)
                    Console.Write("\t" + nums1);
                Console.WriteLine();
            }
            Console.WriteLine("                                                               ");
            var array = new object[0];
            var str = "";
            Console.WriteLine("----------------------Кортежи-------------------------------------");
            (int a, string b, char c, string d, ulong e) kortej = (18, "Maksim", 'p', "Dyadyuk", 500);
            (int, string, char, string, ulong) kortej1 = (20, "Kolya", 'd', "Petrov", 8774);
            Console.WriteLine($"{kortej}");
            Console.WriteLine($"{kortej1}");
            Console.WriteLine($"{kortej.Item1} {kortej.Item5}");
            int first = kortej.Item1;
            string second = kortej.Item2;
            char third = kortej.Item3;
            string fouth = kortej.Item4;
            ulong fifth = kortej.Item5;
            Console.WriteLine($"{first} {second} {third} {fouth} {fifth}");
            if (kortej.CompareTo(kortej1) == 0)
                Console.WriteLine("Кортежи раны");
            else
                Console.WriteLine("Кортежи не равны");
            Console.WriteLine("----------------------Функция-------------------------------------");
            var varIntArray = new[] { 1, 10, 100, 1000 };
            static (int max, int min, int sum, char firstLetter) localFunc(int[] array, string str0)
            {
                int max = 0;
                int min = 9999;
                int sum = 0;
                str0 = "sdfsdf";
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }

                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    sum += array[i];
                }
                char firstLetter = str0[0];
                return (max, min, sum, firstLetter);
            }
            var localTuple = localFunc(varIntArray, str);
            Console.WriteLine(localTuple);
            Console.WriteLine("                                         ");
            static int intLocalFunc1(int num)
            {
                checked
                {
                    num = Int32.MaxValue;
                }
                return num;
            }

            static int intLocalFunc2(int num)
            {
                unchecked
                {
                    num = Int32.MaxValue + 1;
                }
                return num;
            }
            Console.WriteLine(intLocalFunc1(Int32.MaxValue));
            Console.WriteLine(intLocalFunc2(Int32.MaxValue));
        }
    }
}
