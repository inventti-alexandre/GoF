﻿using System;
using Version_01.Class;

namespace Version_01
{
    internal class Program
    {
        private static void Main()
        {
            var instance1 = Singleton.Instance();
            var instance2 = Singleton.Instance();

            if (ReferenceEquals(instance1, instance2))
            {
                instance1.SetOperation();
                Console.WriteLine(instance1.GetOperation());
            }

            Console.ReadKey();
        }
    }
}
