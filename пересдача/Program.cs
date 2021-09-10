using System;
using System.IO;

namespace пересдача
{
    class Program
    {
        public void zadacha()
        {
            StreamWriter wet = new StreamWriter("X:/пересдача/пересдача.txt");
            
            // Ввод размерности
            Console.WriteLine("Введите число строк");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int B = Convert.ToInt32(Console.ReadLine());
            wet.WriteLine("Размер таблицы {0} -> {1}", A, B);
            Console.Clear();

            // Ввод чисел 
            int[,] Massiv = new int[A, B];
            Console.WriteLine("Введите число ограниченное 3 символами \n");
            wet.WriteLine("Исходное число \n");
            for (int i = 0; i < A; i++)
            {
                Console.WriteLine("Вводим числа из строки", i + 1);
                for (int j = 0; j < B; j++)
                {
                    Console.WriteLine("Вводим {0} число", i + 1);
                    Massiv[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();

            //Решение задачи
            int count = 0, cislo; int x1, x2, x3;
            int[] rMassiv = new int[A * B];
            wet.WriteLine("Проверка");
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    x1 = Massiv[i, j] / 100;
                    x2 = Massiv[i, j] % 100 / 10;
                    x3 = Massiv[i, j] % 10;
                    cislo = (int)Math.Pow(x1, 3) + (int)Math.Pow(x2, 3) + (int)Math.Pow(x3, 3);
                    if (cislo == Massiv[i, j])
                    {
                        rMassiv[count] = Massiv[i, j];
                        count = count + 1;
                    }
                }
            }

            wet.WriteLine("Завершено");

            //Ответ
            Console.WriteLine("Начальные значения \n");
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("{0:d3}", Massiv[i, j]);
                    wet.Write("{0:d3}", Massiv[i, j]);
                }
                Console.WriteLine();
                wet.WriteLine();
            }

            Console.WriteLine("Числа решения \n");
            wet.WriteLine("Числа решения \n");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0:d3}", rMassiv[i]);
                wet.Write("{0:d3}", rMassiv[i]);
            }
            Console.WriteLine("Кол-во чисел решения равно {0} \n", count);
            wet.WriteLine("Кол-во чисел решения равно {0} \n", count);
            wet.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.zadacha();
            Console.ReadKey();

        }
    }

}

