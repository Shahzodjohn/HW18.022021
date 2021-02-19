﻿using System.Threading;
using System;

class Program
{
    //1 пример с многопоточным программированием
    static void Main(string[] args)
    {

        Thread myThread = new Thread(new ThreadStart(Count));
        myThread.Start();

        for (int i = 1; i < 9; i++)
        {
            Console.WriteLine("Главный поток:");
            Console.WriteLine(i * i);
            Thread.Sleep(300);
        }

        Console.ReadLine();
    }

    public static void Count()
    {
        for (int i = 1; i < 9; i++)
        {
            Console.WriteLine("Второй поток:");
            Console.WriteLine(i * i);
            Thread.Sleep(400);
        }
    }
}
