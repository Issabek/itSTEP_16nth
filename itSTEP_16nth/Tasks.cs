using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace itSTEP_16nth
{
    public class Tasks
    {
        //Создать коллекцию List<int>.Вывести на экран позицию и значение элемента,
        //являющегося вторым максимальным значением в коллекции.
        //Вывести на экран сумму элементов на четных позициях.
        public static void task1(List<int> list)
        {
            list.Sort();
            int sum = 0;
            for(int i=0;i<list.Count-1;i+=2)
            {
                sum += list[i];
            }
            Console.WriteLine("pos: {0} val: {1} sum: {2}",list.Count-2,list[list.Count-2], sum);
        }

        //Удалить все нечетные элементы списка List<int>
        public static void task2(List<int> list)
        {
            for (int i = list.Count-1; i >=1; i -= 2)
            {
                list.RemoveAt(i);
            }
        }
        //Дана коллекция типа List<double>.Вывести на экран элементы списка,
        //значение которых больше среднего арифметического всех элементов коллекции.
        public static void task3(List<double> list)
        {
            double avg = list.Average();
            foreach(double item in list)
            {
                if(item>avg)
                    Console.WriteLine(item);
            }
        }
        //Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке.
        public static void task4(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            System.Console.WriteLine("Contents of .txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line.Reverse());
            }
            System.Console.ReadKey();
        }
        //Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.
        public static void task5(string s1, string s2)
        {
            bool da = true;
            int length = s1.Length / 2;
            for(int i = 0, j = length; i < length; i++, j--)
            {
                if (s1[i] != s2[j])
                    da = false;
                    break;
            }
            Console.WriteLine(da?"True":"False");
        }
        //Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все слова,
        //начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву, сохраняя исходный порядок в каждой группе слов.
        public static void task6(string path)
        {
            string text = System.IO.File.ReadAllText(path);
            List<char> glasnie = new List<char>{ 'а', 'у', 'е', 'ы', 'о', 'э', 'ю', 'и', 'я' };
            text = Regex.Replace(text, @"[^\w]*", String.Empty);
            string[] temp = text.Split(' ');
            string glas="", sogl="";
            foreach(string item in temp)
            {
                if (glasnie.Contains(item[0]))
                    glas = glas + item + " ";
                else
                    sogl = sogl + item + " ";
            }
            Console.WriteLine("glassnie: {0}\nsoglasnie: {1}",glas,sogl);
        }
        //Дан файл, содержащий числа.За один просмотр файла напечатать элементы файла в следующем порядке:
        //сначала все положительные числа, потом все отрицательные числа, сохраняя исходный порядок в каждой группе чисел.
        public static void task7(string path)
        {
            string text = System.IO.File.ReadAllText(path);;
            string[] temp = text.Split(' ');
            string plus = "", minus = "";
            foreach (string item in temp)
            {
                if (item[0]=='-')
                    minus = minus + item + " ";
                else
                    plus = plus + item + " ";
            }
            Console.WriteLine("положительные: {0}\nотрицательные: {1}", plus, minus);
        }
        
        public Tasks()
        {
        }
    }
}
