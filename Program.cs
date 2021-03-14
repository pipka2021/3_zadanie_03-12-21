using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Ruskiu yazik
            Console.WriteLine("Приветики");
            Console.WriteLine("Введи сторону квадрата, а я посчитаю периметр ");
            Console.Write("Сторона: ");
            int S = Convert.ToInt32(Console.ReadLine());            //ввод стороны

            Console.WriteLine($"Периметр равен = {4*S}");           //периметр квадрата

            Console.WriteLine("\nНажмите любую клавишу для выхода.");//чтобы приложение сразу не закрывалось
            Console.ReadKey();
        }
    }
}
