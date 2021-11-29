using System;

namespace _24variant
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] mas = new int[12];
                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(10, 99);
                    Console.Write(mas[i] + " ");
                }
                Console.WriteLine("Введите последний элемент массива: ");
                int n = int.Parse(Console.ReadLine());
                if (n == (mas[mas.Length - 1]))
                {
                    int sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += mas[i];
                    }
                    Console.WriteLine($"Сумма={sum}");

                }
                else Console.WriteLine("Это не последний элемент массива");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}