using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGOOOOOOOOOOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //11
            /*   try
               {
                   Console.WriteLine("введите количество строк: ");
                   int m = int.Parse(Console.ReadLine());
                   Console.WriteLine("введите количество столбцов: ");
                   int n = int.Parse(Console.ReadLine());
                   Console.WriteLine("введите целое число, которое не больше количества столбцов: ");
                   int k = int.Parse(Console.ReadLine());
                   if (k >= 1 && k <= n)
                   {
                       int[,] f = new int[m, n];
                       Random r = new Random();
                       Console.WriteLine("введите '1' если хотите заполнить массив рандомно\nвведите '2' если хотите заполнить вручную");
                       int dd = int.Parse(Console.ReadLine());
                       if (dd == 1)
                       {
                           for (int i = 0; i < f.GetLength(0); i++)
                           {
                               for (int j = 0; j < f.GetLength(1); j++)
                               {
                                   f[i, j] = r.Next(-10, 10);
                               }
                           }
                       }
                       if (dd == 2)
                       {
                           for (int i = 0; i < f.GetLength(0); i++)
                           {
                               for (int j = 0; j < f.GetLength(1); j++)
                               {
                                   Console.Write($"введите число на позиции M[{i + 1},{j + 1}]: ");
                                   f[i, j] = Convert.ToInt32(Console.ReadLine());
                               }
                           }
                       }

                       for (int i = 0; i < f.GetLength(0); i++)
                       {
                           for (int j = 0; j < f.GetLength(1); j++)
                           {
                               Console.Write($"|{f[i, j],3}");
                           }
                           Console.WriteLine();
                       }


                       int sum = 0;
                       for (int i = 0; i < f.GetLength(0); i++)
                       {
                           sum += f[i, k - 1];
                       }

                       Console.WriteLine($"сумма элементов {k}-го столбца : {sum}");

                       int pro = 1;
                       for (int i = 0; i < f.GetLength(0); i++)
                       {
                           pro *= f[i, k - 1];
                       }

                       Console.WriteLine($"произведение элементов {k}-го столбца : {pro}");
                   }
                   else Console.WriteLine("error");
               }
               catch (FormatException) { Console.WriteLine("нужно ввести цифру!"); }

   */


            //7
            try
            {
                Console.WriteLine("введите количество строк (больше 5): ");
                int m = int.Parse(Console.ReadLine());
                if (m > 5)
                {
                    Console.WriteLine("введите количество столбцов (больше 4): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 4)
                    {
                        int[,] f = new int[m, n];
                        Random r = new Random();
                        Console.WriteLine("введите '1' если хотите заполнить массив рандомно\nвведите '2' если хотите заполнить вручную");
                        int dd = int.Parse(Console.ReadLine());
                        if (dd == 1)
                        {
                            for (int i = 0; i < f.GetLength(0); i++)
                            {
                                for (int j = 0; j < f.GetLength(1); j++)
                                {
                                    f[i, j] = r.Next(-50, 50);
                                }

                            }

                        }
                        if (dd == 2)
                        {
                            for (int i = 0; i < f.GetLength(0); i++)
                            {
                                for (int j = 0; j < f.GetLength(1); j++)
                                {
                                    Console.Write($"введите число на позиции M[{i + 1},{j + 1}]: ");
                                    f[i, j] = Convert.ToInt32(Console.ReadLine());
                                }

                            }
                        }


                        for (int i = 0; i < f.GetLength(0); i++)
                        {
                            for (int j = 0; j < f.GetLength(1); j++)
                            {
                                Console.Write($"|{f[i, j],3}");
                            }
                            Console.WriteLine();
                        }


                        int ss = 0;
                        for (int i = 0; i < f.GetLength(0); i++)
                        {
                            if (f[i, 1] > 15)
                                ss++;
                        }
                        Console.WriteLine($"количество ненулевых элементов второго столбца массива, больших 15: {ss}");


                        int sum = 0, k = 0; double sr = 0;
                        for (int j = 0; j < f.GetLength(1); j++)
                        {
                            if (f[4, j] % 2 != 0)
                            {
                                sum += f[4, j]; k++;
                            }
                        }
                        double rez = sum / k;
                        sr = Math.Round(rez, 2);
                        Console.WriteLine($"среднее арифметическое нечётных чисел пятой строки : {sr}");


                        int sum1 = 0, k1 = 0; double sr1 = 0;
                        for (int i = 0; i < f.GetLength(0); i++)
                        {
                            if (f[i, 3] % 4 == 0)
                            {
                                sum1 += f[i, 3]; k1++;
                                Console.Write($"{f[i, 3],3}");
                            }
                        }
                        double rez1 = sum1 / k1;
                        sr1 = Math.Round(rez1, 2);
                        Console.WriteLine($"среднее арифметическое эелментов четвертого столбца, кратного четырём: {sr1}");
                    }
                    else
                        Console.WriteLine("ой, что-то пошло не так!");
                }
                else Console.WriteLine("ой, что-то пошло не так!");
            }
            catch (FormatException) { Console.WriteLine("нужно ввести цифру!"); }

            Console.ReadKey();

        }
    }
}
