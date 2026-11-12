using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторна робота №5. Варіант 2: факторіал ===");

            //  Введення n з перевіркою (do while: запит виконується хоча б раз)
            int n;
            bool ok;
            do
            {
                Console.Write("Введіть ціле n від 0 до 20: ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok || n < 0 || n > 20)
                {
                    Console.WriteLine("Помилка: потрібне ціле число від 0 до 20.");
                    ok = false;
                }
            }
            while (!ok);

            //  спосіб1 цикл for 
            long factFor = 1;                       // накопичувач добутку починається з 1
            for (int i = 1; i <= n; i++)
            {
                factFor *= i;
            }

            //Спосіб2 цикл while 
            long factWhile = 1;                     // накопичувач добутку
            int k = 1;                              // лічильник
            while (k <= n)
            {
                factWhile *= k;
                k++;                                // крок який наближає умову до хибності
            }

            Console.WriteLine();
            Console.WriteLine($"{n}! (цикл for)   = {factFor}");
            Console.WriteLine($"{n}! (цикл while) = {factWhile}");

            //Таблиця факторіалів від 1 до n 
            if (n == 0)
            {
                // тіло циклу не виконується жодного разу
                Console.WriteLine("n = 0: таблиця порожня, за означенням 0! = 1.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("  n | n!");
                Console.WriteLine("----+---------------------");
                long f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Console.WriteLine($"{i,3} | {f}");
                }
            }

            // квадрат зі стороною size
            Console.WriteLine();
            int size;
            do
            {
                Console.Write("Введіть сторону квадрата від 3 до 20: ");
                ok = int.TryParse(Console.ReadLine(), out size);
                if (!ok || size < 3 || size > 20)
                {
                    Console.WriteLine("Помилка: потрібне ціле число від 3 до 20.");
                    ok = false;
                }
            }
            while (!ok);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    char symbol;
                    if (i == j || i + j == size - 1)
                    {
                        symbol = '#';               // діагоналі
                    }
                    else if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        symbol = '*';               // межа квадрата
                    }
                    else
                    {
                        symbol = ' ';               // решта клітинок
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
