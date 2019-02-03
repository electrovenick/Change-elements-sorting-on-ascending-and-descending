using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перемена_местами_чисел_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
        link0:
            int n;
            int i = 0; int j = 0; int k = 1; double t = 1;
            int ch1 = 1; int ch2 = 1;
            Console.WriteLine("Введите число элементов массива");
            
            n = Convert.ToInt16(Console.ReadLine());
            double [] array = new double[n];
            Console.WriteLine();
            Console.WriteLine("Введите элементы массива");
            while (i < n)
            {
                Console.Write(k + " элемент массива = ");
                array[i] = Convert.ToInt16(Console.ReadLine());
                //array0[i] = array[i];
                k++; i++;
            }
            Console.WriteLine();
            Console.Write("Ваш массив: ");
            for (i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

        link1:
            Console.WriteLine("Нажмите 1 для сортировки по возрастанию");
            Console.WriteLine("Нажмите 2 для сортировки по убыванию");
            Console.WriteLine("Нажмите 3 для перемены элементов местами");
            Console.WriteLine();
            int selection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (selection)
            {
                case (1):
                    Console.WriteLine("Отсортированный по возрастанию массив: ");
                    for (j = 0; j < n - 1; j++)
                    {
                        for (i = 0; i < n - 1; i++)
                        {                            
                            if (array[i] > array[i + 1])
                            {
                                t = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = t;
                            }
                        }
                    }
                    for (i = 0; i < n; i++)
                        Console.Write(array[i] + " ");
                    Console.WriteLine();
                    break;

                case (2):
                    Console.WriteLine("Отсортированный по убыванию массив: ");
                    for (j = 0; j < n - 1; j++)
                    {
                        for (i = 0; i < n - 1; i++)
                        {
                            if (array[i] < array[i + 1])
                            {
                                t = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = t;
                            }
                        }
                    }
                    for (i = 0; i < n; i++)
                        Console.Write(array[i] + " ");
                    Console.WriteLine();
                    break;

                case (3):
                    k = n;
                    Console.WriteLine("Выберете номер 1 элемента от 1 до " + n);
                    ch1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Выберете номер 2 элемента от 1 до " + n);
                    ch2 = Convert.ToInt16(Console.ReadLine());
                    t = array[ch1 - 1];
                    array[ch1 - 1] = array[ch2 - 1];
                    array[ch2 - 1] = t;
                    for (i = 0; i < n; i++)
                        Console.Write(array[i] + " ");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    goto link1;
            }
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("Для продолжения работы с введённм кодом нажмите любую клавишу");
            Console.WriteLine("Нажмите 'Enter' чтобы работать с новым массивом");
            string l = "";
            l = Convert.ToString(Console.ReadLine());
            if (l == "")
                goto link0;
        }
    }
}
