﻿using System;
class Program
{
    static void Main()
    {
        int F, x, y, z;
        double K;
        double max = 0;
        int count = 0;

        for (F = 100; F <= 999; F++)
        {

            x = F / 100;
            y = F / 10 % 10;
            z = F % 10;

            K = F / (x + y + z);
            if (K > max)
            {
                max = K;
                count = F;
            }
            Console.Write(K + " ");
        }
        Console.WriteLine("\nНаибольшее значение -> {0}", count);

        Console.ReadLine();
        
    }
}

// Зарылбеков Абай ДКИП-201
// Медель уулу Ильгиз ДКИП-201