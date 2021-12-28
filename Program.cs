using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 100; int pos = 0;
            int[] mas = new int[10];
            for(int i = 0; i < 10; i++)
            {
                mas[i] = rnd.Next(100);
                if(mas[i] < min)
                {
                    min = mas[i];
                    pos = 1;
                    {
                        Console.WriteLine("{0}", mas[i]);
                    }
                    Console.WriteLine("Наим{0}", min);
                    (mas[8], mas[pos]) = (mas[pos], mas[9]);
                    for (int j = 0; j < 10; j++)
                    {
                         Console.WriteLine("{0}", mas[i]);
                    }
                }
            }
        }
    }
